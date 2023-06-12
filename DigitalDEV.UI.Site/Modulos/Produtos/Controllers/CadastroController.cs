using Microsoft.AspNetCore.Mvc;

namespace DigitalDEV.UI.Site.Modulos.Produto.Controllers
{
    [Area("Produtos")]
    [Route("produtos")]
    public class CadastroController : Controller
    {
        [Route("lista")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("busca")]
        public IActionResult Busca()
        {
            return View();
        }
    }
}
