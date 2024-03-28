using coreDepartmantProject.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;
namespace coreDepartmantProject.Controllers
{
    public class LoginController : Controller
    {

        Context c = new Context();

        [HttpGet]
        public IActionResult LoginPage()
        {
            return View();
        }

        //async varsa task yazılmalı
        public async Task<IActionResult> LoginPanel(Admin p)
        {
            //claims : talepler
            var bilgiler = c.Admins.FirstOrDefault(x => x.Kullanici == p.Kullanici && x.Sifre == p.Sifre);
            if(bilgiler != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, p.Kullanici) // Yeni bir talep oluşturuyoruz
                };
                var useridentity = new ClaimsIdentity(claims, "Login"); // talebın kımlıgı ile ilişkilendirdik .
                                                                        // 2 parametre alır. kimlikten gelen değer, ve autentice tipi
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal); // talebın nesnesini yazdıdırız
                return RedirectToAction("employee", "Personal");
            }
            return View();
        }

    }
}
