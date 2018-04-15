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
            List<NEWS> lsNew = new List<NEWS>();
            for (int i = 0; i < lsAllNew.Count(); i++)
            {
                if (lsAllNew[i].idSubCategory == idSub)
                {
                    lsNew.Add(lsAllNew[i]);
                }
            }
            return lsNew;
            
        }
        // trả về một tin tức khi biết mã

        public NEWS getNews(int id)
        {
            NEWS news = model.NEWS.Find(id);
            return news;
        }

        // them mot tin tuc

        public bool Insert(NEWS news)
        {
            NEWS newsItem = model.NEWS.Find(news.id);

            if (newsItem != null)
            {
                return false;

            }
            model.NEWS.Add(news);

            model.SaveChanges();

            return true;
        }
        // Sửa một tin tuc
        public bool Update(NEWS news)
        {
            NEWS addNews = model.NEWS.Find(news.id);
            if (addNews == null)
            {
                return false;
            }
            addNews.name = news.name;
            addNews.picture = news.picture;
            addNews.content = news.content;
            addNews.detail = news.detail;
            addNews.dateup = news.dateup;
            addNews.tacgia = news.tacgia;
            addNews.avtive = news.avtive;
            addNews.idSubCategory = news.idSubCategory;

           
            model.SaveChanges();

            return true;
        }

        // Xóa một tin tuc
        public bool Delete(int id)
        {
            NEWS newsItem = model.NEWS.Find(id);
            if (newsItem == null)
            {
                return false;
            }
            model.NEWS.Remove(newsItem);

            model.SaveChanges();
            return true;
        }
    }
}