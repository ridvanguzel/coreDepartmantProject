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
        [HttpGet] //sayfa yüklendıgınde çlaışacak
        public IActionResult NewDepartmant()
        {
            return View();
        }
        [HttpPost] // post işlemi gerçekleştiğinde gerçekleşecek
        public IActionResult NewDepartmant(departmant d) // departmantlardan verilerimiz gelecek
        {
            c.departmants.Add(d); // departmanların içerisine d den gelen verileri ekle. D den gelen değerler, bizim // textbox'a girdiğimiz değerler olacak.
            c.SaveChanges(); //değişiklikleri kaydet
            return RedirectToAction("depart"); // aksiyona yönlendriecek
            
        }

        public IActionResult DeleteDepartmant(int id)
        {
            var dep = c.departmants.Find(id); //parametre olarak gönderdiğimiz id yi bul dedik. burada "dep" değişkenine departmanlar tablosundaki id'yi bul dedik
            c.departmants.Remove(dep);// dep degişkeninde buldugu id yi dep degişkenine atadık ve ıonu kaldırmak için bu işlemi kullanıyoruz
            c.SaveChanges();
            return RedirectToAction("depart");

        }
        public IActionResult BringDepartmant(int id)
        {
            var depinfo = c.departmants.Find(id);
            return View("BringDepartmant", depinfo);
        }
        public IActionResult UpdateDepartmant(departmant d)
        {
            var depinfo = c.departmants.Find(d.deptid); // burada tablodan istedigimiz veriyi aldık ve dep değişkenine atadık.
            depinfo.deptname = d.deptname; // hafızada yani dep değişkeninde tuttugumuz değeride parametreden elen değer ile değiştirdik.
            c.SaveChanges();
            return RedirectToAction("depart");
        }

        public IActionResult DepartmantDetail(int Id)
        {
            var degerler = c.personals.Where(x => x.depart.deptid == Id).ToList();
            var brmad = c.departmants.Where(x => x.deptid == Id).Select(x => x.deptname).FirstOrDefault();

            ViewBag.departname = brmad;
            return View(degerler);
        }
    }
}
