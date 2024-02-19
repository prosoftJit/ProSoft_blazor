using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ProSoft.Controllers
{
    public class PolicyController : Controller
    {
        void CreateCookie(string name)
        {
            CookieOptions co = new()
            {
                MaxAge = TimeSpan.FromSeconds(30 * 60),
                SameSite = SameSiteMode.Strict
            };

            Response.Cookies.Append("pn", name, co);
        }
        string? LoggedUser()
        {
            return Request.Cookies["pn"];
        }
        [HttpPost("api/login")]
        public IActionResult Login(string Name, string Pass)
        {
            if (Name != "paulo_cmv" || Pass != "9763pros")
                return Json("Usuário ou senha inválida");

            Response.Cookies.Delete("pn");

            CreateCookie(Name);

            return Redirect("/");
        }
        [HttpGet("api/logout")]
        public IActionResult Logout()
        {
            Response.Cookies.Delete("pn");

            return Redirect("/");
        }
        [HttpGet("api/logeduser")]
        public IActionResult LogedUser()
        {
            return Json(LoggedUser());
        }
    }
}
