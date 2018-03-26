using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShop1.Areas.Admin.Models.Dao;

namespace WebShop1.Areas.Admin.Controllers
{
    public class AdminHomeController : Controller
    {
        // GET: Admin/AdminHome
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Logout()
        {
            Session["username"] = null;

            return Redirect("Login");
        }

        [HttpPost]
        public ActionResult Login(string username,string password)
        {
            LoginDao dao = new LoginDao();
            if (dao.checkLogin(username, password))
            {
                Session["username"] = username;
                return Redirect("../Product/Index");
            }
            else
                return Redirect("Login");
        }
    }
}