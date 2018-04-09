
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TH13Chieu.Models.Entities;
using TH13Chieu.Models.Functions;

namespace TH13Chieu.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index(string ReturnUrl)
        {
            ViewBag.ReturnURL = ReturnUrl;
            return View();
        }
        // GET: /Login/

        [HttpPost]
        public ActionResult Index(Account model, string ReturnUrl)
        {
            if (String.IsNullOrEmpty(model.UserName))
            {
                ModelState.AddModelError("", "Chưa nhập tên đăng nhập");
                return View("Index", model);
            }
            if (String.IsNullOrEmpty(model.Password))
            {
                ModelState.AddModelError("", "Chưa nhập mật khẩu");
                return View("Index", model);
            }


            var acc = new NguoiDungF().Login(model.UserName, model.Password);


            if (acc == null)
            {
                ModelState.AddModelError("", "Người dùng không tồn tại");
                return View("Index", model);
            }
            else
            {
                Session["Login"] = acc;
                if (string.IsNullOrEmpty(ReturnUrl))
                {

                    return RedirectToAction("Index", "SanPham");
                }
                else
                {
                    return Redirect(ReturnUrl);
                }
            }

           
        }
        //
        // GET: /Login/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Login/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Login/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Login/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Login/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Login/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Login/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
