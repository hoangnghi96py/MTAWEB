namespace MTAWEB.Models.ENTITY
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DatabaseModel : DbContext
    {
        public DatabaseModel()
            : base("name=DatabaseModel")
        {
        }

        public virtual DbSet<ADMIN> ADMINs { get; set; }
        public virtual DbSet<CATEGOTY> CATEGOTies { get; set; }
        public virtual DbSet<NEWS> NEWS { get; set; }
        public virtual DbSet<PICTURE> PICTUREs { get; set; }
        public virtual DbSet<SUBCATEGOTY> SUBCATEGOTies { get; set; }
        public virtual DbSet<UNITCATEGOTY> UNITCATEGOTies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ADMIN>()
                .Property(e => e.username)
                .IsFixedLength();

            modelBuilder.Entity<ADMIN>()
                .Property(e => e.password)
                .IsFixedLength();

            modelBuilder.Entity<ADMIN>()
                .HasMany(e => e.NEWS)
                .WithOptional(e => e.ADMIN)
                .HasForeignKey(e => e.nguoidang);

            modelBuilder.Entity<CATEGOTY>()
                .HasMany(e => e.SUBCATEGOTies)
                .WithOptional(e => e.CATEGOTY)
                .HasForeignKey(e => e.idCategory);

            modelBuilder.Entity<NEWS>()
                .HasMany(e => e.PICTUREs)
                .WithOptional(e => e.NEWS)
                .HasForeignKey(e => e.idNews);

            modelBuilder.Entity<PICTURE>()
                .Property(e => e.linkPicture)
                .IsFixedLength();

            modelBuilder.Entity<SUBCATEGOTY>()
                .HasMany(e => e.NEWS)
                .WithOptional(e => e.SUBCATEGOTY)
                .HasForeignKey(e => e.idSubCategory);

            modelBuilder.Entity<SUBCATEGOTY>()
                .HasMany(e => e.UNITCATEGOTies)
                .WithOptional(e => e.SUBCATEGOTY)
                .HasForeignKey(e => e.idSubCategory);

            modelBuilder.Entity<UNITCATEGOTY>()
                .HasMany(e => e.NEWS)
                .WithOptional(e => e.UNITCATEGOTY)
                .HasForeignKey(e => e.idUnitCategory);
        }
    }
}
