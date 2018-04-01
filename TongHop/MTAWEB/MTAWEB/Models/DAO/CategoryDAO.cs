using MTAWEB.Models.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTAWEB.Models.DAO
{
    public class CategoryDAO
    {

        DatabaseModel model = new DatabaseModel();
        public List<CATEGOTY> getListCate()
        {
            return model.CATEGOTies.ToList();
        }
    }
}