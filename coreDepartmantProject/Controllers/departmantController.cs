using Microsoft.AspNetCore.Mvc;
using coreDepartmantProject.Models;

namespace coreDepartmantProject.Controllers
{
    public class departmantController : Controller
    {
        Context c = new Context();
        //Context c adında bir nesne oluşturduk ve bu nesneleri çektik
        public IActionResult depart()
        {
            var degerler = c.departmants.ToList();
            return View(degerler);
        }
    }
}
