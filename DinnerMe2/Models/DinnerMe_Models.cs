namespace DinnerMe2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DinnerMe_Models : DbContext
    {
        public DinnerMe_Models()
            : base("name=DinnerMe_Models")
        {
        }

        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Desk> Desks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Bookings)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Desk>()
                .HasMany(e => e.Bookings)
                .WithRequired(e => e.Desk)
                .WillCascadeOnDelete(false);
        }
    }
}
