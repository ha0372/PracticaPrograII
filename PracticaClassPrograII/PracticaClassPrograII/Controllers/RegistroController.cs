using Microsoft.AspNetCore.Mvc;
using PracticaClassPrograII.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaClassPrograII.Controllers
{
    public class RegistroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ClsValidacion validacion) 
        {
            if (ModelState.IsValid)
            {
                return View("Registro");

            }
            else
            {
                return View("Index");
            }
        }
    }
}
