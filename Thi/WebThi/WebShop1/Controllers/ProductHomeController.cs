using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShop1.Models;
using WebShop1.Areas.Admin.Models.Dao;

namespace WebShop1.Controllers
{
    public class ProductHomeController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            ProductDao proDao = new ProductDao();
            ViewBag.lisPro = proDao.ListProduct();
            return View();
        }
    }
}