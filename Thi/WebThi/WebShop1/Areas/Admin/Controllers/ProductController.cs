using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShop1.Areas.Admin.Models.Dao;
using WebShop1.Areas.Admin.Models.Entites;
using System.IO;

namespace WebShop1.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        
        
        public ActionResult Delete(int id)
        {
            ProductDao dao = new ProductDao();
            dao.Delete(id);
            return Redirect("~/Admin/Product/Index");
        }

        public ActionResult Index(int pagenum=1, int pageSize=4)
        {
            ProductDao dao = new ProductDao();
            return View(dao.ListProductPage(pagenum, pageSize));
        }

        //public ActionResult Add()
        //{
        //    List<Category> ls = new List<Category>();
        //    CategoriesDao dao = new CategoriesDao();
        //    ViewBag.listcat = dao.ListCategories();

        //    List<Trademark> ls1 = new List<Trademark>();
        //    TrademarkDao dao1 = new TrademarkDao();
        //    ViewBag.listcat1 = dao1.ListTrademark();
        //    return View("Add");
            
        //}
        [HttpPost]
        public ActionResult Add(string idcategories, string idtrademark, string name, string transport, string oldprice, string newprice, string number, string Levelsong, string Unit, HttpPostedFileBase photo)
        {
           
          
            Product product = new Product();
           
           
            product.name = name;
            product.transport = transport;           
            product.oldprice = Int32.Parse(oldprice);
            product.newprice = Int32.Parse(newprice);           
            product.number = Int32.Parse(number);
            product.Levelsong = Levelsong;           
            product.idcategories = Int32.Parse(idcategories);
            product.idtrademark = Int32.Parse(idtrademark);           
            if (ModelState.IsValid)
            {
                if(photo!=null && photo.ContentLength > 0)
                {

                    var path = Path.Combine(Server.MapPath("~/Areas/Admin/Content/photo/"),
                        System.IO.Path.GetFileName(photo.FileName));
                    photo.SaveAs(path);
                    product.picture = photo.FileName;
                    ProductDao dao = new ProductDao();
                    dao.Add(product);
                }
                return RedirectToAction("Index");
            }else
            {
                return View(product);
            }

        }

    }
}