namespace WebShop1.Areas.Admin.Models.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Picture")]
    public partial class Picture
    {
        [Key]
        public int idpicture { get; set; }

        [StringLength(30)]
        public string name { get; set; }

        public int? wednesday { get; set; }

        public int? idproduct { get; set; }

        public virtual Product Product { get; set; }
    }
}
