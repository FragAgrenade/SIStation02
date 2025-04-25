using Microsoft.AspNetCore.Mvc;
using sistation.Models;
using sistation.Data;

namespace sistation.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RegisterController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View("Register");
        }

        [HttpPost]
        public IActionResult Registrar(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();

                return RedirectToAction("Index", "Login");
            }

            return View("Register", user);
        }
    }
}
