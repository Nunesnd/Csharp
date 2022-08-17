using Microsoft.AspNetCore.Mvc;

namespace AplicacaoProjetoMVC.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult ApagarConfirma()
        {
            return View();
        }
    }
}
