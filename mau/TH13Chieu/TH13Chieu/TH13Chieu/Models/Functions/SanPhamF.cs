using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TH13Chieu.Models.Entities;

namespace TH13Chieu.Models.Functions
{
    public class SanPhamF
    {
        private MyContext context;

        public SanPhamF()
        {
            context = new MyContext();
        }

        // Trả về danh muc
        public IQueryable<SanPham> DSSanPham
        {
            get { return context.SanPhams; }
        }

        // Trả về một đối tượng danh mục, khi biết Khóa
        public SanPham FindEntity(string MaSP)
        {
            SanPham dbEntry = context.SanPhams.Find(MaSP);
            return dbEntry;
        }

        // Thêm một đối tượng
        public bool Insert(SanPham model)
        {
            SanPham dbEntry = context.SanPhams.Find(model.MaSP);

            if (dbEntry != null)
            {
                return false;

            }
            context.SanPhams.Add(model);

            context.SaveChanges();

            return true;
        }

        // Sửa một đối tượng
        public bool Update(SanPham model)
        {
            SanPham dbEntry = context.SanPhams.Find(model.MaSP);
            //   LoaiBanDoc dbEntry = context.LoaiBanDocs.
            //  Where(x => x.LoaiBanDoc1 = model.LoaiBanDoc1).FirstOrDefault();
            if (dbEntry == null)
            {
                return false;
            }
            dbEntry.TenSP = model.TenSP;
            dbEntry.GiaSP = model.GiaSP;
            dbEntry.MaDM = model.MaDM;
            dbEntry.MoTa = model.MoTa;
            dbEntry.UrlAnh = model.UrlAnh;
            // Sửa các trường khác cũng như vậy
            context.SaveChanges();

            return true;
        }

        // Xóa một đối tượng
        public bool Delete(string MaSP)
        {
            SanPham dbEntry = context.SanPhams.Find(MaSP);
            if (dbEntry == null)
            {
                return false;
            }
            context.SanPhams.Remove(dbEntry);

            context.SaveChanges();
            return true;
        }
    }
}