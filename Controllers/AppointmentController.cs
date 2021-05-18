using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            //string dateNow = DateTime.Now.ToShortDateString();
            //return Ok(dateNow);

            return View();
        }
        public IActionResult Detail(int id)
        {
            return Ok("You have entered id = " + id);
        }
    }
}
