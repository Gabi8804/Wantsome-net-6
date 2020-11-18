using StoreApp.BusinessLogic.BusinessEntities;
using StoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Security;

namespace StoreApp.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly UserHandler userHandler;
        // GET: Account
        public AccountController()
        {
            userHandler = new UserHandler();
        }
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated == true)
            {
                return RedirectToAction("Index", "Home"); 
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
            
        }
        public ActionResult Login()
        {
            ViewBag.Message = "";
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel user)
        {
            var isValid = userHandler.IsUserValid(user.UserName,user.Password);
            if (!isValid)
            {
                ViewBag.Status = "Error";
                ViewBag.Message = "Invalid UserName or Password";
                return View();
            }
            else
            {
                FormsAuthentication.SetAuthCookie(user.UserName, false);
                return RedirectToAction("Index", "Home");
            }
           
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public ActionResult Register()
        {
            ViewBag.Message = "";
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterViewModel user)
        {
            var registerUser = new UserModel
            {
                FirstName=user.FirstName,
                LastName=user.LastName,
                UserName=user.UserName,
                Password= user.Password
            };
            userHandler.Create(registerUser);
            ViewBag.Status = "Success";
            ViewBag.Message = "Your account has been created!";

            return RedirectToAction("Login", "Account");
        }
    }
}