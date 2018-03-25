namespace MTAWEB.Models.ENTITY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NEWS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NEWS()
        {
            PICTUREs = new HashSet<PICTURE>();
        }

        public int id { get; set; }

        [StringLength(250)]
        public string name { get; set; }

        [StringLength(250)]
        public string picture { get; set; }

        [Column(TypeName = "ntext")]
        public string content { get; set; }

        [Column(TypeName = "ntext")]
        public string detail { get; set; }

        public bool? avtive { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateup { get; set; }

        [StringLength(250)]
        public string tacgia { get; set; }

        public int? nguoidang { get; set; }

        public int? idSubCategory { get; set; }

        public int? idUnitCategory { get; set; }

        public virtual ADMIN ADMIN { get; set; }

        public virtual SUBCATEGOTY SUBCATEGOTY { get; set; }

        public virtual UNITCATEGOTY UNITCATEGOTY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PICTURE> PICTUREs { get; set; }
    }
}
