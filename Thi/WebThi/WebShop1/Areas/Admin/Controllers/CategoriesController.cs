using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShop1.Areas.Admin.Models.Dao;

namespace WebShop1.Areas.Admin.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Admin/Categories
        public ActionResult Index()
        {
            CategoriesDao dao = new CategoriesDao();
            return View(dao.ListCategories());
        }
    }
}