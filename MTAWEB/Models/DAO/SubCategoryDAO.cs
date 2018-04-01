using MTAWEB.Models.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTAWEB.Models.DAO
{
    public class SubCategoryDAO
    {
        DatabaseModel model = new DatabaseModel();
        public List<SUBCATEGOTY> getSubCate(int idCate)
        {
            List<SUBCATEGOTY> lsSub = model.SUBCATEGOTies.ToList();
            List<SUBCATEGOTY> lsSubCan = new List<SUBCATEGOTY>();
            for (int i= 0; i < lsSub.Count(); i++)
            {
                if (lsSub[i].idCategory == idCate)
                {
                    lsSubCan.Add(lsSub[i]);
                }
            }
            return lsSubCan;
        }
    }
}