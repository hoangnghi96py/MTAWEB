namespace MTAWEB.Models.ENTITY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SUBCATEGOTY")]
    public partial class SUBCATEGOTY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SUBCATEGOTY()
        {
            NEWS = new HashSet<NEWS>();
            UNITCATEGOTies = new HashSet<UNITCATEGOTY>();
        }

        public int id { get; set; }

        [StringLength(250)]
        public string name { get; set; }

        public int? lever { get; set; }

        public int? idCategory { get; set; }

        public virtual CATEGOTY CATEGOTY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NEWS> NEWS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UNITCATEGOTY> UNITCATEGOTies { get; set; }
    }
}
