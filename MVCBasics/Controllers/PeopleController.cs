using Microsoft.AspNetCore.Mvc;
using MVCBasics.Models;
using MVCBasics.ViewModels;
using System;
using System.Net.Http.Headers;

namespace MVCBasics.Controllers
{
    public class PeopleController : Controller
    {
        public static PeopleViewModel vm = new PeopleViewModel();

        public IActionResult Index()
        {
            if (PeopleViewModel.listOfPeople.Count == 0)
            {
                PeopleViewModel.SeedPeople();
            }

            vm.tempList = PeopleViewModel.listOfPeople;

            return View(vm);
        }

        public IActionResult PersonDelete(string id)
        {
            var personToDelete = PeopleViewModel.listOfPeople.FirstOrDefault(p => p.Id == id);

            if (personToDelete != null)
            {
                PeopleViewModel.listOfPeople.Remove(personToDelete);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult CreatePerson(PersonViewModel pwm)
        {
            //if (person != null)
            //{
            //    person.Id = Guid.NewGuid().ToString();
            //    PeopleViewModel.listOfPeople.Add(person);
            //}

            ModelState.Remove("Id");
            if (ModelState.IsValid)
            {
                Person p = new Person(Guid.NewGuid().ToString(), pwm.Name, pwm.PhoneNumber, pwm.City);

                PeopleViewModel.listOfPeople.Add(p);
            }

            return View("Index", vm );
        }

        [HttpPost]
        public IActionResult SearchPerson(string searchTerm)
        {
            PeopleViewModel vm = new PeopleViewModel();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                //vm.tempList = PeopleViewModel.listOfPeople.FindAll(p => p.Equals(searchTerm));
                vm.tempList = PeopleViewModel.listOfPeople.FindAll(p => p.Name.Contains(searchTerm) || p.City.Contains(searchTerm));
            }

            //return RedirectToAction("Index", vm);
            return View("Index", vm);
        }
    }
}
