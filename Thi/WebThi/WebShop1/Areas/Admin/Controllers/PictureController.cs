using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShop1.Areas.Admin.Models.Dao;

namespace WebShop1.Areas.Admin.Controllers
{
    public class PictureController : Controller
    {
        // GET: Admin/Picture
        public ActionResult Index()
        {
            PictureDao dao = new PictureDao();
            return View(dao.ListPicture());
        }

    }
}