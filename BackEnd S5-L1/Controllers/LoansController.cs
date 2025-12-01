using Microsoft.AspNetCore.Mvc;

namespace BackEnd_S5_L1.Controllers
{
    public class LoansController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
