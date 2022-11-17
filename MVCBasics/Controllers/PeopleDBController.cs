using Microsoft.AspNetCore.Mvc;
using MVCBasics.Data;
using MVCBasics.Models;

namespace MVCBasics.Controllers
{
    public class PeopleDBController : Controller
    {
        readonly ApplicationDbContext _context;

        public PeopleDBController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.People.ToList());
        }

        public IActionResult Delete(string id)
        {
            if (id != null)
            {
                var person = _context.People.FirstOrDefault(p => p.Id == id);
                if (person != null)
                {
                    _context.People.Remove(person);
                    _context.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }

        public IActionResult CreatePerson()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePerson(Person person)
        {
            ModelState.Remove("Id");
            if (ModelState.IsValid)
            {
                person.Id = Guid.NewGuid().ToString();
                _context.People.Add(person);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
