namespace WebShop1.Areas.Admin.Models.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bill")]
    public partial class Bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bill()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        public int idbill { get; set; }

        [StringLength(50)]
        public string username { get; set; }

        [StringLength(50)]
        public string address { get; set; }

        public DateTime purchasedate { get; set; }

        [StringLength(50)]
        public string payments { get; set; }

        public int? iduser { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
