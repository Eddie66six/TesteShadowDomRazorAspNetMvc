using Microsoft.AspNetCore.Mvc;

namespace Relatorios.Areas.Teste.Controllers
{
    public class TesteController : Controller
    {
        // GET: Teste
        [Area("Teste")]
        public ActionResult Index()
        {
            return View();
        }
    }
}