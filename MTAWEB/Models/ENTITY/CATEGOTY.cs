namespace MTAWEB.Models.ENTITY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CATEGOTY")]
    public partial class CATEGOTY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CATEGOTY()
        {
            SUBCATEGOTies = new HashSet<SUBCATEGOTY>();
        }

        public int id { get; set; }

        [StringLength(250)]
        public string name { get; set; }

        public int? lever { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUBCATEGOTY> SUBCATEGOTies { get; set; }
    }
}
