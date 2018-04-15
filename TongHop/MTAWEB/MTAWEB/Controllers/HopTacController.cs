using MTAWEB.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MTAWEB.Controllers
{
    public class HopTacController : Controller
    {
        // GET: HopTac
        public ActionResult Index()
        {
            SubCategoryDAO subCateDao = new SubCategoryDAO();
            ViewBag.lisSubCate = subCateDao.getSubCate(7);
            UnitCategoryDAO unitCateDao = new UnitCategoryDAO();
            //  ViewBag.lisUnit = unitCateDao.getListUnitCate();
            return View();
        }


        public ActionResult TinHopTac(int id)
        {
            SubCategoryDAO subCateDao = new SubCategoryDAO();
            ViewBag.lisSubCate = subCateDao.getSubCate(7);
            newsDAO newdao = new newsDAO();
            ViewBag.lisNew = newdao.getListNewsSub(id);
            return View();
        }
    }
}