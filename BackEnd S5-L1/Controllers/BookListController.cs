using Microsoft.AspNetCore.Mvc;

namespace BackEnd_S5_L1.Controllers
{
    public class BookListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
