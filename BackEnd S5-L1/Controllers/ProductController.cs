using BackEnd_S5_L1.Migrations;
using BackEnd_S5_L1.Models.Entity;
using BackEnd_S5_L1.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            var products = this._productService.GetAll();
            return View(products);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            product.Id = Guid.NewGuid();
            bool isCreated = this._productService.Create(product);

            var products = this._productService.GetAll();


            return View(products);

        }

        [HttpGet]
        public IActionResult Update(Guid Id)
        {
            var product = _productService.GetId(Id);
            if (product == null)
                return NotFound();
            return View(product);
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            if (product.Id == Guid.Empty)
                return BadRequest("ID non valido.");


            var bookId = _productService.GetId(product.Id);
            if (bookId == null)
                return NotFound();


            bookId.Titolo = product.Titolo;
            bookId.Autore = product.Autore;
            bookId.Prezzo = product.Prezzo;
            bookId.Copertina = product.Copertina;
            bookId.bookSummary = product.bookSummary;


            bool updated = _productService.Update(bookId);

            return RedirectToAction("Create");
        }



        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            bool result = _productService.Delete(id);
            return RedirectToAction("Create");
        }
    }
}
