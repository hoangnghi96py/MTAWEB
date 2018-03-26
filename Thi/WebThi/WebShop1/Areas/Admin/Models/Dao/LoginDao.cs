using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShop1.Areas.Admin.Models.Entites;

namespace WebShop1.Areas.Admin.Models.Dao
{
    public class LoginDao
    {
        ShopDataModel model;
        public LoginDao()
        {
            model = new ShopDataModel();
        }
        public bool checkLogin(string username, string password)
        {
            bool check = false;
            int a=  model.Logins.Where(x => x.username == username && x.password == password).ToList().Count();
            if (a >= 1) check = true;
            return check;
        }
    }
}