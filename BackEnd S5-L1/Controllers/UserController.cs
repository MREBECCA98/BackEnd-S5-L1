using BackEnd_S5_L1.Models.Entity;
using BackEnd_S5_L1.Services;
using Microsoft.AspNetCore.Mvc;



namespace BackEnd_S5_L1.Controllers
{
    public class UserController : Controller
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var users = this._userService.GetAll();
            return View(users);
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            user.Id = Guid.NewGuid();
            bool isCreated = this._userService.Create(user);

            var users = this._userService.GetAll();


            return View(users);

        }
    }
}
