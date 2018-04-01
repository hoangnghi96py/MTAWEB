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
        public NEWS getNew(int id)
        {
            return model.NEWS.Find(id);
        }

        public List<NEWS> getListNewsSub(int idSub)
        {

            List<NEWS> lsAllNew = model.NEWS.ToList();
            List<NEWS> lsNewSub = new List<NEWS>();
            for (int i = 0; i < lsAllNew.Count(); i++)
            {
                if (lsAllNew[i].idSubCategory == idSub)
                {
                    lsNewSub.Add(lsAllNew[i]);
                }
            }
            return lsNewSub;
            
        }

    }
}