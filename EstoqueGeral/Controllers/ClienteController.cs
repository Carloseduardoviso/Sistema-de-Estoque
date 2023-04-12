using Microsoft.AspNetCore.Mvc;

namespace EstoqueGeral.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult frmCliente()
        {
            return View(frmCliente);
        }

        public IActionResult istCliente()
        {
            return View(istCliente);
        }
    }
}
