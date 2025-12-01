using BackEnd_S5_L1.Models.Entity;
using BackEnd_S5_L1.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd_S5_L1.Controllers
{
    public class BookListController : Controller
    {
        private readonly ProductService _productService;

        public BookListController(ProductService productService)
        {
            _productService = productService; //DI
        }
        public IActionResult Index()
        {
            Product product = new Product()
            {
                Id = Guid.NewGuid(),
                Copertina = "https://m.media-amazon.com/images/I/51Z0nLAfLmL._SX218_BO1,204,203,200_QL40_FMwebp_.jpg",
                Titolo = "Clean Code: A Handbook of Agile Software Craftsmanship",
                Autore = "Robert C. Martin",
                Prezzo = 29.99M,
                bookSummary = "Even bad code can function. But if code isn't clean, it can bring a development organization to its knees. Every year, countless hours and significant resources are lost because of poorly written code. But it doesn't have to be that way. Noted software expert Robert C. Martin presents a revolutionary paradigm with Clean Code: A Handbook of Agile Software Craftsmanship. Martin has teamed up with his colleagues from Object Mentor to distill their best agile practice of cleaning code \"on the fly\" into a book that will instill within you the values of a software craftsman and make you a better programmer—but only if you work at it. What kind of work will you be doing? You'll be reading code—lots of code. And you'll be challenged to think about what’s right about that code, and what’s wrong with it. More importantly, you'll be challenged to reassess your professional values and your commitment to your craft."
            };

            //insert into db
            bool result = this._productService.Create(product);
            //Console.WriteLine(result ? "Salvato!" : "Non salvato!");

            List<Product> ListProduct = this._productService.GetAll();

            return View();
        }
    }
}
