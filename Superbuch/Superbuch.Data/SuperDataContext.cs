using Superbuch.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Superbuch.Data
{
    [DbConfigurationType(typeof(Configuration))]
    class SuperDataContext : DbContext
    {

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }

        public SuperDataContext() : base()
        {
            Database.SetInitializer<SuperDataContext>(null);
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Account>()
                .ToTable("accounts")
                .HasMany(e => e.bookings)
                .WithRequired(e => e.account)
                .HasForeignKey(e => e.account_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Booking>()
                .ToTable("bookings")
                .Property(e => e.sum)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Category>()
                .ToTable("categories")
                .HasMany(e => e.bookings)
                .WithRequired(e => e.category)
                .HasForeignKey(e => e.category_id)
                .WillCascadeOnDelete(false);

        }

    }
}