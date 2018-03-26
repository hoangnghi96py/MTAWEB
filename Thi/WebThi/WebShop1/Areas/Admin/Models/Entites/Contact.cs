namespace WebShop1.Areas.Admin.Models.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contact")]
    public partial class Contact
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contact()
        {
            Users = new HashSet<User>();
        }

        [Key]
        public int idcontact { get; set; }

        [StringLength(30)]
        public string name { get; set; }

        [StringLength(30)]
        public string email { get; set; }

        [StringLength(30)]
        public string phonenumber { get; set; }

        [StringLength(30)]
        public string company { get; set; }

        [StringLength(30)]
        public string message { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}
