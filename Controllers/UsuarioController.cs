using Microsoft.AspNetCore.Mvc;

namespace ProjetoJogos.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
