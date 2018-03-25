namespace MTAWEB.Models.ENTITY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PICTURE")]
    public partial class PICTURE
    {
        [Key]
        public int idPicture { get; set; }

        [StringLength(250)]
        public string linkPicture { get; set; }

        public int? idNews { get; set; }

        public virtual NEWS NEWS { get; set; }
    }
}
