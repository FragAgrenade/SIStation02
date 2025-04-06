using Microsoft.AspNetCore.Mvc;
using sistation.Models;

namespace sistation.Controllers
{
    public class LoginController : Controller
    {
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
                if (model.Email == "teste@exemplo.com" && model.Senha == "123456")
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "E-mail ou senha inválidos.");
                }
            }

            return View("Login", model);
        }
    }
}
