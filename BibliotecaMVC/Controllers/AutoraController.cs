using Microsoft.AspNetCore.Mvc;

namespace BibliotecaMVC
{
    public class AutoraController : Controller 
    {  
        public IActionResult Autora()
        {
            var listaDeAutoras = new Autora("Ana").Model;
            return View(listaDeAutoras);
        }
    }
}