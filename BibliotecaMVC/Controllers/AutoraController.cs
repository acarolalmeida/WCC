using Microsoft.AspNetCore.Mvc;

namespace BibliotecaMVC
{
    public class AutoraController : Controller 
    {  
        public IActionResult Autora()
        {
            return View();
        }
        
        public string Welcome()
        {
            return "Boas Vindas!";
        }
    }
}