using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShop1.Areas.Admin.Models.Entites;

namespace WebShop1.Areas.Admin.Models.Dao
{
    public class CategoriesDao
    {
        ShopDataModel model;
        public CategoriesDao()
        {
            model = new ShopDataModel();
        }
        public List<Category> ListCategories()
        {
            return model.Categories.ToList();
        }
        public Category getById(int id)
        {
            return model.Categories.Single(i => i.idcategories == id);
        }
    }
}