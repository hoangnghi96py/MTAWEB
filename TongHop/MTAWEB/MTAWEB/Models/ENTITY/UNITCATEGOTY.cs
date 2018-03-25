namespace MTAWEB.Models.ENTITY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UNITCATEGOTY")]
    public partial class UNITCATEGOTY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UNITCATEGOTY()
        {
            NEWS = new HashSet<NEWS>();
        }

        public int id { get; set; }

        [StringLength(250)]
        public string name { get; set; }

        public int? lever { get; set; }

        public int? idSubCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NEWS> NEWS { get; set; }

        public virtual SUBCATEGOTY SUBCATEGOTY { get; set; }
    }
}
