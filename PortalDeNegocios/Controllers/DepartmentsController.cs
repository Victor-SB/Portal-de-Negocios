using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PortalDeNegocios.Models;


namespace PortalDeNegocios.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>
            {
                new Department { Id = 1, Name = "Institucional" },
                new Department { Id = 2, Name = "Mezanino" }
            };

            return View(list);
        }
    }
}
