using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using K21T2_TheBOSS_Team4.Models;

namespace K21T2_TheBOSS_Team4.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            { }
            return View(model);
        }
        // Log in
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserLogin login, string ReturnUrl)
        {
            string message = "";
            DemoPPCRentalEntities01 db = new DemoPPCRentalEntities01();
            var u = db.USERs.Where(x => x.Email == login.Email).FirstOrDefault();
            if (u != null)
            {
                if (string.Compare(login.Password, u.Password) == 0)
                {
                    int timeout = login.Remember ? 525600 : 1; // 1 year
                    var ticket = new FormsAuthenticationTicket(login.Email, login.Remember, timeout);
                    var cookie = new HttpCookie(FormsAuthentication.FormsCookieName);
                    cookie.Expires = DateTime.Now.AddMinutes(timeout);
                    cookie.HttpOnly = true;
                    Response.Cookies.Add(cookie);

                    if (Url.IsLocalUrl(ReturnUrl))
                    {
                        return Redirect(ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "ProjectAdmin", new { Area = "Admin" });

                    }

                }
                else
                {

                }
            }
            else
            {
                message = "Địa chỉ Email hoặc mật khẩu không hợp lệ";
            }
            return View(login);
        }

        // Log out
        [Authorize]
        [HttpPost]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "User");
        }
    }
}