
namespace MVCBasics.Models
{
    public class GuessingGameModel
    {
        public static int GeneratedNum { get; set; }
        public static int NoOfGuesses { get; set; }


        public static void StartGuessingGame()
        {
            var rand = new Random();
            GeneratedNum = rand.Next(0, 100);
            
            NoOfGuesses = 0;
        }

        public static string EvaluateNumbers(int userNum)
        {
            if (userNum > GeneratedNum)
            {
                NoOfGuesses += 1;
                return "Too High";
            }
            else if (userNum < GeneratedNum)
            {
                NoOfGuesses += 1;
                return "Too Low";
            }
            else
            {
                NoOfGuesses = 0;
                return "Win!!";
            }
        }

        public static bool checkGameStatus(string status)
        {
            if (status == "Win!!")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
