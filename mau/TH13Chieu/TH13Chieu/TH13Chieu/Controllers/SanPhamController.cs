using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TH13Chieu.Models.Entities;
using TH13Chieu.Models.Functions;
using TH13Chieu.Models.Security;

namespace TH13Chieu.Controllers
{
    public class SanPhamController : Controller
    {
        //
        // GET: /SanPham/

        public ActionResult ViewDS()
        {
            var model = new SanPhamF().DSSanPham.ToList();
            return View(model);
        }

        public ActionResult ChiTietSP(string id)
        {
            var model = new SanPhamF().FindEntity(id);
            return View(model);
        }

        public ActionResult TimKiem(string TuKhoa)
        {
            var model = new SanPhamF().DSSanPham.Where(x => x.TenSP.Contains(TuKhoa)).ToList();
            return View("ViewDS",model);
        }

        public ActionResult Index()
        {
            var model = new SanPhamF().DSSanPham.Where(x=>x.TenSP!=null).ToList();
            return View(model);
        }

        [ChildActionOnly]
        public ActionResult Menu()
        {
            var model = new DanhMucF().DanhMUcs;
            return PartialView("menuDM", model);
        }
        //
        // GET: /SanPham/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }


        //
        // GET: /SanPham/Create

         [CustomAuthorize(Roles = "Admin")]
        public ActionResult Create()
        {
            var dm = new DanhMucF().DanhMUcs.Where(p => p.TenDM != null);
            ViewBag.MaDM = new SelectList(dm, "MaDM", "TenDM", null);
            return View();
        }

        //
        // POST: /SanPham/Create

        [HttpPost]
        public ActionResult Create(SanPham model, HttpPostedFileBase UrlAnh)
        {
            try
            {
                // TODO: Add update logic here

                if (UrlAnh == null)
                {
                    ModelState.AddModelError("File", "Chưa upload file ảnh");
                }
                else if (UrlAnh.ContentLength > 0)
                {                 //TO:DO
                    var fileName = Path.GetFileName(UrlAnh.FileName);
                    var path = Path.Combine(Server.MapPath("~/Content/Images"), fileName);
                    UrlAnh.SaveAs(path);                    //   

                    SanPhamF spF = new SanPhamF();
                    model.UrlAnh = fileName;
                    if (spF.Insert(model))
                    {
                        return RedirectToAction("Index");
                    }
                }
            }
            catch
            {
                return View();
            }
            return View();
        }

        //
        // GET: /SanPham/Edit/5

        public ActionResult Edit(string id)
        {
            var model = new SanPhamF().FindEntity(id);
            return View(model);
        }

        //
        // POST: /SanPham/Edit/5

        [HttpPost]
        public ActionResult Edit( SanPham model)
        {
            try
            {
                // TODO: Add update logic here
                if (new SanPhamF().Update(model))
                {

                    return RedirectToAction("ViewDS");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /SanPham/Delete/5

        public ActionResult Delete(string id)
        {
            var model = new SanPhamF().FindEntity(id);
            return View("Edit", model);
        }

        //
        // POST: /SanPham/Delete/5

        [HttpPost]
        public ActionResult Delete(SanPham model)
        {
            try
            {
                if (new SanPhamF().Delete(model.MaSP))
                {

                    return RedirectToAction("ViewDS");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
