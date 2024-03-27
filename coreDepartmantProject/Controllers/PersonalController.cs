using coreDepartmantProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;

namespace coreDepartmantProject.Controllers
{
    public class PersonalController : Controller
    {
        Context c = new Context();
        public IActionResult Employee()
        {
            //Birimin ismini listelemek için kullandık Include metodu için entityframework kodu lazm
            var degerler = c.personals.Include(x => x.depart).ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult  AddNewPersonal()
        {

            //DEPARTMANLARI DROPDOWNDA LİSTELEMEK İÇİN BU YÖNTEMİ KULLANDIK. PERSONAL HTML TARAFINDA DA KOD VAR.

            List<SelectListItem> degerler = (from x in c.departmants.ToList
                                             ()
                                             select new SelectListItem
                                             {
                                                 Text = x.deptname, // kullanıcının gördüğü
                                                 Value = x.deptid.ToString() // DB DE KI ÇALIŞACAK DEĞER
                                             }).ToList() ;

            ViewBag.dgr = degerler;
            return View();
        }
        [HttpPost]
        public IActionResult AddNewPersonal(personal p)
        {

            var pers = c.departmants.Where(x => x.deptid == p.depart.deptid).FirstOrDefault();
            p.depart = pers;

            c.personals.Add(p); 
            c.SaveChanges();
            return RedirectToAction("employee");
        }
        public IActionResult BringPersonal(int Id)
        {
            List<SelectListItem> degerler = (from x in c.departmants.ToList
                                           ()
                                             select new SelectListItem
                                             {
                                                 Text = x.deptname, // kullanıcının gördüğü
                                                 Value = x.deptid.ToString() // DB DE KI ÇALIŞACAK DEĞER
                                             }).ToList();
         
            ViewBag.dgr = degerler;
           var pers = c.personals.Find(Id);
           

          
            c.SaveChanges();
            return View("BringPersonal", pers);
        }

        public IActionResult UpdatePersonal(personal p)
        {

            var persinfo = c.personals.Find(p.personalid);
            persinfo.personalname = p.personalname;
            persinfo.personallastname = p.personallastname;
            persinfo.personalsehir = p.personalsehir;
            //persinfo.depart.deptid = p.depart.deptid;
            c.SaveChanges();
            return RedirectToAction("employee", "Personal");
        }

        public IActionResult DeletePersonal(int Id)
        {
            var pers = c.personals.Find(Id);
            c.personals.Remove(pers);
            c.SaveChanges();
            return RedirectToAction("employee");
        }

        public IActionResult PersonalDetail(int Id)
        {
            var degerler = c.personals
                 .Include(x => x.depart)
                 .FirstOrDefault(x => x.personalid == Id);

            return View(degerler);
        }

    }
}

