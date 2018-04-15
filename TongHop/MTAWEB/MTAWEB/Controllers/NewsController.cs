using MTAWEB.Models.DAO;
using MTAWEB.Models.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MTAWEB.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
          public ActionResult ChiTietNews(int id)
        {
            var model = new newsDAO().getNews(id);
            return View(model);
        }
    }
}