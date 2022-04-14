using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers {
    public class DepartamentsController : Controller {
        public IActionResult Index() {

            List<Departament> dptList = new List<Departament>();

            dptList.Add(new Departament { ID = 1, Name = "Electronics"});
            dptList.Add(new Departament { ID = 2, Name = "Fashion" });

            return View(dptList);
        }
    }
}
