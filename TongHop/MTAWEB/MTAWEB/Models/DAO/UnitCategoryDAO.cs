using MTAWEB.Models.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTAWEB.Models.DAO
{

    public class UnitCategoryDAO
    {
        DatabaseModel model = new DatabaseModel();
        public List<UNITCATEGOTY> getListUnitCate(int idSub)
        {
            List<UNITCATEGOTY> lsAllUnit = model.UNITCATEGOTies.ToList();
            List<UNITCATEGOTY> lsUnit = new List<UNITCATEGOTY>();
            for (int i = 0; i < lsAllUnit.Count(); i++)
            {
                if (lsAllUnit[i].idSubCategory == idSub)
                {
                    lsUnit.Add(lsAllUnit[i]);
                }
            }
            return lsUnit;
        }
    }
}