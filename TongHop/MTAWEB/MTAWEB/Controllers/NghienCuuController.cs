using MTAWEB.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MTAWEB.Controllers
{
    public class NghienCuuController : Controller
    {
        // GET: NghienCuu
        public ActionResult Index()
        {

            SubCategoryDAO subCateDao = new SubCategoryDAO();
            ViewBag.lisSubCate = subCateDao.getSubCate(6);
            UnitCategoryDAO unitCateDao = new UnitCategoryDAO();
            //  ViewBag.lisUnit = unitCateDao.getListUnitCate();
            return View();
        }


        public ActionResult tinNghienCuu(int id)
        {
            SubCategoryDAO subCateDao = new SubCategoryDAO();
            ViewBag.lisSubCate = subCateDao.getSubCate(6);
            newsDAO newdao = new newsDAO();
            ViewBag.lisNew = newdao.getListNewsSub(id);
            return View();
        }
    }
}