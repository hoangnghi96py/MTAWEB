using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShop1.Areas.Admin.Models.Dao;
using WebShop1.Areas.Admin.Models.Entites;
using WebShop1.Models.Bean;

namespace WebShop1.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        public ActionResult Add(int id)
        {
            ProductDao dao = new ProductDao();
            Product pro = dao.getById(id);
            ShoppingCart cart = (ShoppingCart)Session["cart"];

            if (cart == null)
            {
                cart = new ShoppingCart();
            }
            if (pro != null)
            {
                cart.Add(pro.id, pro.name, (double)pro.newprice, 1);
            }
            Session["cart"] = cart;

            return Redirect(Request.UrlReferrer.ToString());// link lai trang cu
        }
        public ActionResult Detail()
        {

            return View();
        }
        public ActionResult Delete(int id)
        {
            ShoppingCart cart = (ShoppingCart)Session["cart"];

            if (cart == null)
            {
                cart = new ShoppingCart();
            }
            cart.Delete(id);
            Session["cart"] = cart;
            return Redirect(Request.UrlReferrer.ToString());// link lai trang cu
        }
        [HttpPost]
        public ActionResult Buy(string phone, string name)
        {
            // lưu bảng bill -> idbill
            
            BillDao dao = new BillDao();
            Bill bill = new Bill();
            bill.username = name;
            bill.iduser = phone;
            int id = dao.Add(bill);

            ShoppingCart cart = (ShoppingCart)Session["cart"];
            if (cart != null)
            {
                List<ItemCart> ListCart = cart.ListItem;
                List<BilDetail> ls = new List<BilDetail>();
                for(int i = 0; i < ListCart.Count; i++)
                {
                    BilDetail billdetail = new BilDetail();
                    billdetail.idbill = idbill;
                    billdetail.idproduct = idproduct;
                    billdetail.quantity = ListCart[i].quantity;
                    billdetail.prict =(decimal) ListCart[i].price;
                    ls.Add(billdetail);
                    // lưu bảng billandProduct
                    dao.addBillDetai(ls);
                }

            }
            Session["cart"] = null;
            return View();
        }
    }
}