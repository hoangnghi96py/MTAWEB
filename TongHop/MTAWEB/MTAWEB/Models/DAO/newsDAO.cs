using MTAWEB.Models.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTAWEB.Models.DAO
{
    public class newsDAO
    {
        DatabaseModel model = new DatabaseModel();
        public List<NEWS> getListNews()
        {
            return model.NEWS.ToList();
        }
    }
}