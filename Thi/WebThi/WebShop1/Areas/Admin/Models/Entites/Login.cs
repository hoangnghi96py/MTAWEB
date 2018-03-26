namespace WebShop1.Areas.Admin.Models.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Login")]
    public partial class Login
    {
        [Key]
        [StringLength(50)]
        public string username { get; set; }

        [StringLength(50)]
        public string password { get; set; }

        [StringLength(50)]
        public string fullname { get; set; }
    }
}
