using Microsoft.AspNetCore.Mvc;

namespace ProjetoExemplo.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
