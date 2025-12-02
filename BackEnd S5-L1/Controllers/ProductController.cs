using BackEnd_S5_L1.Models.Entity;
using BackEnd_S5_L1.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd_S5_L1.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var products = _productService.GetAll();
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            product.Id = Guid.NewGuid();
            bool isCreated = _productService.Create(product);


            return View(product);

        }
    }
}
