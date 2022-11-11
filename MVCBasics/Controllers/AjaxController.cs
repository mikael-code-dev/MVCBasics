using Microsoft.AspNetCore.Mvc;
using MVCBasics.Models;
using MVCBasics.ViewModels;

namespace MVCBasics.Controllers
{
    public class AjaxController : Controller
    {
        public static PeopleViewModel vm = new PeopleViewModel();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetPeople()
        {
            if (PeopleViewModel.listOfPeople.Count == 0)
            {
                PeopleViewModel.SeedPeople();
            }

            vm.tempList = PeopleViewModel.listOfPeople;

            return PartialView("_AjaxListPeoplePartial", vm);
        }

        [HttpPost]
        public IActionResult DeletePerson(string id)
        {
            var personToDelete = PeopleViewModel.listOfPeople.FirstOrDefault(p => p.Id == id);

            if (personToDelete != null)
            {
                PeopleViewModel.listOfPeople.Remove(personToDelete);
            }

            return RedirectToAction("GetPeople");
        }

        [HttpPost]
        public IActionResult ShowPersonDetail(string id)
        {
            Person? person = PeopleViewModel.listOfPeople.FirstOrDefault(p => p.Id == id);

            if (person == null)
            {
                ViewBag.ERROR = "Person not found";
            }

            return PartialView("_AjaxDetailsForPerson", person);
        }
    }
}
