using Microsoft.AspNetCore.Mvc;
using MVCBasics.Models;

namespace MVCBasics.Controllers
{
    public class GuessingGameController : Controller
    {
        public IActionResult Index()
        {
            if(String.IsNullOrEmpty(HttpContext.Session.GetString("GeneratedNum")))
            {
                GuessingGameModel.StartGuessingGame();
                HttpContext.Session.SetInt32("GeneratedNum", GuessingGameModel.GeneratedNum);
                HttpContext.Session.SetInt32("NoOfGuess", GuessingGameModel.NoOfGuesses);

                ViewBag.MessageWin = null;
                ViewBag.ShowBothNums = null;
                ViewBag.MessageEval = null;
            }
            else
            {
                ViewBag.MessageEval = $"Guess a number";
                ViewBag.NoOfGuesses = HttpContext.Session.GetInt32("NoOfGuess");
            }


            return View();
        }

        [HttpPost]
        public IActionResult Index(int numGuess)
        {
            var evaluation = GuessingGameModel.EvaluateNumbers(numGuess);
            var gameStatus = GuessingGameModel.checkGameStatus(evaluation);

            if (gameStatus)
            {
                ViewBag.MessageWin = "Hey you guessed the right number. Guess on a new number...";

                GuessingGameModel.StartGuessingGame();
                HttpContext.Session.SetInt32("GenereatedNum", GuessingGameModel.GeneratedNum);
            }
            else
            {
                ViewBag.MessageEval = $"{numGuess}: {evaluation}";
                HttpContext.Session.SetInt32("NoOfGuess", GuessingGameModel.NoOfGuesses);
                ViewBag.NoOfGuesses = HttpContext.Session.GetInt32("NoOfGuess");
            }

            ViewBag.Message = "";
            return View();
        }
    }
}
