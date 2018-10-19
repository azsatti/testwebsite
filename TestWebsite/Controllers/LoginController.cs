namespace TestWebsite.Controllers
{
    using System;
    using System.Web;
    using System.Web.Mvc;
    using Models;

    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            var authenticator = new Authenticator();
            var loginResult = authenticator.Authenticate(model.AuthCode);

            if (!loginResult)
            {
                return View("Error");
            }

            var cookie = new HttpCookie("LoggedIn",
                "true");
            Response.Cookies.Add(cookie);

            return View("Success");
        }

        public ActionResult Logout()
        {
            var cookie = new HttpCookie("LoggedIn") {Expires = DateTime.Now.AddDays(-1)};
            Response.Cookies.Add(cookie);
            return View("Success");
        }
    }
}