namespace WebShop1.Areas.Admin.Models.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Bills = new HashSet<Bill>();
        }

        [Key]
        public int iduser { get; set; }

        [StringLength(30)]
        public string name { get; set; }

        [StringLength(30)]
        public string address { get; set; }

        public DateTime? birthday { get; set; }

        [StringLength(30)]
        public string password { get; set; }

        [StringLength(30)]
        public string phonenumber { get; set; }

        [StringLength(30)]
        public string email { get; set; }

        public int? idcontact { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }

        public virtual Contact Contact { get; set; }
    }
}
