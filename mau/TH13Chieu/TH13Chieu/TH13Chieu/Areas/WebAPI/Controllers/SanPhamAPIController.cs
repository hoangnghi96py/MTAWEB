using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TH13Chieu.Models.Entities;
using TH13Chieu.Models.Functions;

namespace TH13Chieu.Areas.WebAPI.Controllers
{
    public class SanPhamAPIController : ApiController
    {
        // GET api/sanphamapi
        public IEnumerable<SanPham> Get()
        {
            var model =new SanPhamF().DSSanPham.ToList();
            return model;
        }

        // GET api/sanphamapi/5
        public SanPham Get(string id)
        {
            var model = new SanPhamF().FindEntity(id);
            return model;
        }

        // POST api/sanphamapi
        public bool Post(SanPham model)
        {
            return new SanPhamF().Insert(model);}

        

        // PUT api/sanphamapi/5
        public bool Put(string id, SanPham model)
        {
           return new SanPhamF().Update(model);
        }

        // DELETE api/sanphamapi/5
        public bool Delete(string id)
        {
            return new SanPhamF().Delete(id);
        }
    }
}
