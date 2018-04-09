
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TH13Chieu.Models.Entities;

namespace TH13Chieu.Models.Functions
{
    public class CHITIETHDF
    {
        private MyContext context;

        public CHITIETHDF()
        {
            context = new MyContext();
        }

        // Trả về danh muc
        public IQueryable<CHITIETHD> DSCHITIETHD
        {
            get { return context.CHITIETHDs; }
        }

        // Trả về một đối tượng danh mục, khi biết Khóa
        public CHITIETHD FindEntity(int MaDM)
        {
            CHITIETHD dbEntry = context.CHITIETHDs.Find(MaDM);
            return dbEntry;
        }

        // Thêm một đối tượng
        public bool Insert(CHITIETHD model)
        {
            CHITIETHD dbEntry = context.CHITIETHDs.Find(model.MaHD, model.MaSP);

            if (dbEntry != null)
            {
                return false;

            }
            context.CHITIETHDs.Add(model);
            context.SaveChanges();

            return true;
        }

        // Sửa một đối tượng
        public bool Update(CHITIETHD model)
        {
            CHITIETHD dbEntry = context.CHITIETHDs.Find(model.MaHD, model.MaSP);
            //   LoaiBanDoc dbEntry = context.LoaiBanDocs.
            //  Where(x => x.LoaiBanDoc1 = model.LoaiBanDoc1).FirstOrDefault();
            if (dbEntry == null)
            {
                return false;
            }
            dbEntry.SoLuong = model.SoLuong;
            // Sửa các trường khác cũng như vậy
            context.SaveChanges();

            return true;
        }

        // Xóa một đối tượng
        public bool Delete(int MaDM)
        {
            CHITIETHD dbEntry = context.CHITIETHDs.Find(MaDM);
            if (dbEntry == null)
            {
                return false;
            }
            context.CHITIETHDs.Remove(dbEntry);

            context.SaveChanges();
            return true;
        }
    }
}