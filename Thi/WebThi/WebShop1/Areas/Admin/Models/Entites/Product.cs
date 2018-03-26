namespace WebShop1.Areas.Admin.Models.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Pictures = new HashSet<Picture>();
            Bills = new HashSet<Bill>();
        }

        public int id { get; set; }

        [StringLength(30)]
        public string name { get; set; }

        [StringLength(30)]
        public string transport { get; set; }

        public decimal? oldprice { get; set; }

        public decimal? newprice { get; set; }

        public int? number { get; set; }

        [StringLength(50)]
        public string Levelsong { get; set; }

        public int? Unit { get; set; }

        [StringLength(50)]
        public string picture { get; set; }

        public int? idcategories { get; set; }

        public int? idtrademark { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Picture> Pictures { get; set; }

        public virtual Trademark Trademark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }
    }
}
