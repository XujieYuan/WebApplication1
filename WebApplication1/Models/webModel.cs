namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class webModel : DbContext
    {
        public webModel()
            : base("name=webModel")
        {
        }

        public virtual DbSet<House_category> House_category { get; set; }
        public virtual DbSet<Tip> Tips { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<House_category>()
                .HasMany(e => e.Tips)
                .WithRequired(e => e.House_category)
                .HasForeignKey(e => e.House_categeryId)
                .WillCascadeOnDelete(false);
        }
    }
}
