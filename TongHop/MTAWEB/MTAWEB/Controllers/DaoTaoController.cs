using MTAWEB.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MTAWEB.Controllers
{
    public class DaoTaoController : Controller
    {
        // GET: DaoTao
        public ActionResult Index()
        {
            SubCategoryDAO subCateDao = new SubCategoryDAO();
            ViewBag.lisSubCate = subCateDao.getSubCate(3);
            UnitCategoryDAO unitCateDao = new UnitCategoryDAO();
          //  ViewBag.lisUnit = unitCateDao.getListUnitCate();
            return View();
        }


        public ActionResult getNewSub(int idSub)
        {
            newsDAO newdao = new newsDAO();
            ViewBag.lisNewSub = newdao.getListNewsSub(idSub);
            return View();
        }

        // hien thi chi tiet tin tuc
        public ActionResult ChiTietNew(int id)
        {
            newsDAO newdao = new newsDAO();
            ViewBag.New = newdao.getNew(id);
            return View();
        }

    }
}