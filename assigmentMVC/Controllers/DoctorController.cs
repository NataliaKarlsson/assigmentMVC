using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace assigmentMVC.Controllers
{
    public class DoctorController : Controller
    {
        [HttpPost]
        public IActionResult FeverCheck(double temp)
        {
            if (temp != 0)
            {
                ViewBag.Msg = Models.Doctor.Diagnose(temp);
                return View();
            }
            else
            {
                ViewBag.Msg = "Enter temp plizz";
                return View();
            }
        }
        [HttpGet]
        public IActionResult FeverCheck()
        {
            return View();
        }
    }
}
