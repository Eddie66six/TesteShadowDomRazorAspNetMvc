using Microsoft.AspNetCore.Mvc;

namespace Relatorios.Areas.Teste.Controllers
{
    public class ImpressaoController : Controller
    {
        [Area("Teste")]
        public ActionResult Index()
        {
            ViewBag.Impressoes = new[] { "123", "1111" };
            return View();
        }
    }
}