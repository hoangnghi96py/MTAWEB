using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShop1.Areas.Admin.Models.Entites;
using PagedList;

namespace WebShop1.Areas.Admin.Models.Dao
{
    public class ProductDao
    {
        ShopDataModel model;
        public ProductDao()
        {
            model = new ShopDataModel();
        }

        public List<Product> ListProduct()
        {
            return model.Products.ToList();
        }

        public int Delete(int id)
        {
            Product pro = model.Products.Find(id);
            
            if (pro != null)
            {
                model.Products.Remove(pro);
                return model.SaveChanges();
            }
            else return -1;
        }
        public Product getById(int id)
        {
            return model.Products.Single(i => i.id == id);
        
        }

        public IEnumerable<Product> ListProductPage(int pagenum, int pageSize)
        {
            return model.Products.OrderByDescending(a => a.id).ToPagedList(pagenum, pageSize);
        }
        public void Add(Product pro)
        {
            model.Products.Add(pro);
            model.SaveChanges();
        }

        
    }
}