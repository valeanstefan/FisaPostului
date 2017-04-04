namespace FisaPostului.Domain.Database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Repository;

    public partial class DBContext : DbContext
    {

        public DBContext()
            : base("name=DBContext1")
        {           
        }

        public virtual DbSet<Users> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.user_password)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.email)
                .IsUnicode(false);
        }
    }
}
