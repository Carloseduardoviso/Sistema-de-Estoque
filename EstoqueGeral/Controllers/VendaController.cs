using Microsoft.AspNetCore.Mvc;

namespace EstoqueGeral.Controllers
{
    public class VendaController : Controller
    {
        public IActionResult venda()
        {
            return View(venda);
        }  
    }
}
