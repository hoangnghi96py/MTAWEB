using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShop1.Areas.Admin.Models.Dao;

namespace WebShop1.Areas.Admin.Controllers
{
    public class TrademarkController : Controller
    {
        // GET: Admin/Trademark
        public ActionResult Index()
        {
            TrademarkDao dao = new TrademarkDao();
            return View(dao.ListTrademark());
        }
    }
}