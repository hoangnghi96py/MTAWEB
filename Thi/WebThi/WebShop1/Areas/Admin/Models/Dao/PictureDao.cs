using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShop1.Areas.Admin.Models.Entites;

namespace WebShop1.Areas.Admin.Models.Dao
{
    public class PictureDao
    {
        ShopDataModel model;
        public PictureDao()
        {
            model = new ShopDataModel();
        }
        public List<Picture> ListPicture()
        {
            return model.Pictures.ToList();
        }
    }
}