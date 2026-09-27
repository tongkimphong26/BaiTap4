using Microsoft.AspNetCore.Mvc;
using BaiTapBuoi4.Models;

namespace BaiTapBuoi4.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (model.Username == "admin" && model.Password == "123")
            {
                return Content("Login success");
            }

            return Content("Login failed");
        }
    }
}