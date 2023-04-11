using Microsoft.AspNetCore.Mvc;

namespace EstoqueGeral.Controllers
{
    public class FornecedorController : Controller
    {
        public IActionResult frmFornecedor()
        {
            return View(frmFornecedor);
        }
    }
}
