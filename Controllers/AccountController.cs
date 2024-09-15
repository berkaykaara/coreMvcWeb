using coreMvcWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreMvcWeb.Controllers
{
    public class AccountController : Controller
    {
        UserDetailsModel model;
        string name;
        string password;
        public IActionResult User()
        {
            ViewBag.Username = name;
            ViewBag.Password = password;
            return View(model);
        }
        public IActionResult addUser()
        {
            model = new UserDetailsModel();

            ViewBag.Username = model.Username;
            ViewBag.Password = model.Password;
            name = ViewBag.Username;
            password = ViewBag.Password;

            return View();
        }
    }
}
