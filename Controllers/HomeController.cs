using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebAppFormMVC.Models;

namespace WebAppFormMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AplicationDBContext _contexto;

        public HomeController(AplicationDBContext contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(ContactMessages modelo)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", modelo);
            }

            _contexto.ContactMessages.Add(modelo);
            _contexto.SaveChanges();

            TempData["SuccessMessage"] = "Tu mensaje se envio con exito!";

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
