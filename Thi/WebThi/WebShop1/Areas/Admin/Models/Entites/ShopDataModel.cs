namespace WebShop1.Areas.Admin.Models.Entites
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ShopDataModel : DbContext
    {
        public ShopDataModel()
            : base("name=ShopDataModel4")
        {
        }

        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Trademark> Trademarks { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bill>()
                .HasMany(e => e.Products)
                .WithMany(e => e.Bills)
                .Map(m => m.ToTable("BillandProduct").MapLeftKey("idbill").MapRightKey("idproduct"));

            modelBuilder.Entity<Category>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<Contact>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<Contact>()
                .Property(e => e.email)
                .IsFixedLength();

            modelBuilder.Entity<Contact>()
                .Property(e => e.phonenumber)
                .IsFixedLength();

            modelBuilder.Entity<Contact>()
                .Property(e => e.company)
                .IsFixedLength();

            modelBuilder.Entity<Contact>()
                .Property(e => e.message)
                .IsFixedLength();

            modelBuilder.Entity<Login>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Picture>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.transport)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.oldprice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.newprice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Pictures)
                .WithOptional(e => e.Product)
                .HasForeignKey(e => e.idproduct)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Trademark>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.address)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.password)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.phonenumber)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.email)
                .IsFixedLength();
        }
    }
}
