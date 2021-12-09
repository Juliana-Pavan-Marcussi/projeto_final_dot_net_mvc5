using CrudMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudMvc.Controllers
{
    public class DepartmentsController : Controller
    {

        public IActionResult Index()
        {

            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Eletrônicos" });
            list.Add(new Department { Id = 2, Name = "Beleza" });

            return View(list);
        }

        public IActionResult Create()
        {

            return View();
        }
    }
}
