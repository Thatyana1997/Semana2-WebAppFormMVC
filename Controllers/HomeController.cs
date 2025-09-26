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
            var viewModel = new ContactViewModel
            {
                NuevoMensaje = new ContactMessages(),
                listaMensajes = _contexto.ContactMessages.ToList() //select *from contactMessages;
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Submit(ContactViewModel modelo)
        {
            if (!ModelState.IsValid)
            {
                modelo.listaMensajes = _contexto.ContactMessages.ToList();  
                return View("Index", modelo);
            }

            _contexto.ContactMessages.Add(modelo.NuevoMensaje);
            _contexto.SaveChanges(); //insert into values(1,1,1,);

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
