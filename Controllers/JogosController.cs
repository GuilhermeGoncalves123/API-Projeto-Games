using Microsoft.AspNetCore.Mvc;

namespace ProjetoJogos.Controllers
{
    public class JogosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
