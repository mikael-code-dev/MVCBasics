using Microsoft.AspNetCore.Mvc;
using MVCBasics.Models;

namespace MVCBasics.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult CheckFever()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckFever(double temp, string selectScale)
        {
            ViewBag.SelectScale = selectScale;
            ViewBag.Temp = temp;
            ViewBag.Message = DoctorModel.CheckTemp(temp, selectScale);

            return View();
        }
    }
}
