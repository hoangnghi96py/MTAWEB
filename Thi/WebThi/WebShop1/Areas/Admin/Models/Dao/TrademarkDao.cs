    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShop1.Areas.Admin.Models.Entites;

namespace WebShop1.Areas.Admin.Models.Dao
{
    public class TrademarkDao
    {
        ShopDataModel model;
        public TrademarkDao()
        {
            model = new ShopDataModel();
        }
        public List<Trademark> ListTrademark()
        {
            return model.Trademarks.ToList();
        }
        public Trademark getById(int id)
        {
            return model.Trademarks.Single(i => i.idtrademark == id);
        }

    }
}