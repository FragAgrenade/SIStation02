using Microsoft.AspNetCore.Mvc;
using sistation.Models;
using sistation.Data;
using System.Linq;

namespace sistation.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoginController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]
        public IActionResult Entrar(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var usuario = _context.Users
                    .FirstOrDefault(u => u.Email == model.Email && u.PasswordHash == model.Senha);

                if (usuario != null)
                {
                    TempData["UserLogged"] = usuario.Username;
                    return RedirectToAction("Index", "Friends");
                }

                ModelState.AddModelError(string.Empty, "E-mail ou senha inválidos.");
            }

            return View("Login", model);
        }
    }
}
