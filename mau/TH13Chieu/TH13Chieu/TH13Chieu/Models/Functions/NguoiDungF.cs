
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TH13Chieu.Models.Entities;

namespace TH13Chieu.Models.Functions
{
    public class NguoiDungF
    {

        private MyContext context;


        public Account Login(string username, string pass)
        {   var result = context.NguoiDungs.Where(a => a.UserName.Equals(username) && 
                                                       a.PassWord.Equals(pass)).FirstOrDefault();
            Account t = null;
            if (result != null)
            {
                t = new Account();
                t.UserName = result.UserName;
                t.Password = result.PassWord;
                t.Roles = (from a in context.Roles
                           join b in context.UserInRoles
                           on a.IDRole equals b.IDRole
                           where (a.RoleName != null && b.UserName.Equals(username))
                           select a.RoleName).ToList();
            }
            return t;
        }

        public NguoiDungF()
        {
            context = new MyContext();
        }

        // Trả về danh muc
        public IQueryable<NguoiDung> DSNguoiDung
        {
            get { return context.NguoiDungs; }
        }

        // Trả về một đối tượng danh mục, khi biết Khóa
        public NguoiDung FindEntity(string username)
        {
            NguoiDung dbEntry = context.NguoiDungs.Find(username);
            return dbEntry;
        }


        // Thêm một đối tượng
        public bool Insert(NguoiDung model)
        {
            NguoiDung dbEntry = context.NguoiDungs.Find(model.UserName);

            if (dbEntry != null)
            {
                return false;

            }
            context.NguoiDungs.Add(model);
            context.SaveChanges();

            return true;
        }

        // Sửa một đối tượng
        public bool Update(NguoiDung model)
        {
            NguoiDung dbEntry = context.NguoiDungs.Find(model.UserName);
         //   LoaiBanDoc dbEntry = context.LoaiBanDocs.
                              //  Where(x => x.LoaiBanDoc1 = model.LoaiBanDoc1).FirstOrDefault();
            if (dbEntry == null)
            {
                return false;
            }
            dbEntry.PassWord = model.PassWord;
            dbEntry.HoTen = model.HoTen;
            // Sửa các trường khác cũng như vậy
            context.SaveChanges();

            return true;
        }

        // Xóa một đối tượng
        public bool Delete(string username)
        {
            NguoiDung dbEntry = context.NguoiDungs.Find(username);
            if (dbEntry == null)
            {
                return false;
            }
            context.NguoiDungs.Remove(dbEntry);
            context.SaveChanges();
            return true;
        }
    }
}