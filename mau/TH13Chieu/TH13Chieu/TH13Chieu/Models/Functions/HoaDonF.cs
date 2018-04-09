
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TH13Chieu.Models.Entities;

namespace TH13Chieu.Models.Functions
{
    public class HOADONF
    {
    
         private MyContext context;

         public HOADONF()
        {
            context = new MyContext();
        }

        // Trả về danh muc
        public IQueryable<HOADON> DSHOADON
        {
            get { return context.HOADONs; }
        }

        // Trả về một đối tượng danh mục, khi biết Khóa
        public HOADON FindEntity(int MaDM)
        {
            HOADON dbEntry = context.HOADONs.Find(MaDM);
            return dbEntry;
        }

        // Thêm một đối tượng
        public int Insert(HOADON model)
        {
            HOADON dbEntry = context.HOADONs.Find(model.MaHD);

            if (dbEntry != null)
            {
                return -1;

            }
            context.HOADONs.Add(model);
            context.SaveChanges();

            return model.MaHD;
        }

        // Sửa một đối tượng
        public bool Update(HOADON model)
        {
            HOADON dbEntry = context.HOADONs.Find(model.MaHD);
         //   LoaiBanDoc dbEntry = context.LoaiBanDocs.
                              //  Where(x => x.LoaiBanDoc1 = model.LoaiBanDoc1).FirstOrDefault();
            if (dbEntry == null)
            {
                return false;
            }
            dbEntry.Hoten = model.Hoten;
            // Sửa các trường khác cũng như vậy
            context.SaveChanges();

            return true;
        }

        // Xóa một đối tượng
        public bool Delete(int MaDM)
        {
            HOADON dbEntry = context.HOADONs.Find(MaDM);
            if (dbEntry == null)
            {
                return false;
            }
            context.HOADONs.Remove(dbEntry);

            context.SaveChanges();
            return true;
        }
    }
}