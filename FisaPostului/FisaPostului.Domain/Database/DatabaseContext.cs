namespace FisaPostului.Domain.Database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }

        public virtual DbSet<Disciplina> date_disciplina { get; set; }
        public virtual DbSet<Program> date_program { get; set; }
        public virtual DbSet<Users> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Disciplina>()
                .Property(e => e.denumirea_disciplinei)
                .IsUnicode(false);

            modelBuilder.Entity<Disciplina>()
                .Property(e => e.codul_disciplinei)
                .IsUnicode(false);

            modelBuilder.Entity<Disciplina>()
                .Property(e => e.titular_activitati_curs)
                .IsUnicode(false);

            modelBuilder.Entity<Disciplina>()
                .Property(e => e.titularul_activitati_aplicatii)
                .IsUnicode(false);

            modelBuilder.Entity<Disciplina>()
                .Property(e => e.semestru)
                .IsUnicode(false);

            modelBuilder.Entity<Disciplina>()
                .Property(e => e.tip_evaluare)
                .IsUnicode(false);

            modelBuilder.Entity<Disciplina>()
                .Property(e => e.regimul_disciplinei)
                .IsUnicode(false);

            modelBuilder.Entity<Program>()
                .Property(e => e.institutie_invatamant_superior)
                .IsUnicode(false);

            modelBuilder.Entity<Program>()
                .Property(e => e.facultatea)
                .IsUnicode(false);

            modelBuilder.Entity<Program>()
                .Property(e => e.departamentul)
                .IsUnicode(false);

            modelBuilder.Entity<Program>()
                .Property(e => e.ciclu_studii)
                .IsUnicode(false);

            modelBuilder.Entity<Program>()
                .Property(e => e.specializarea)
                .IsUnicode(false);

            modelBuilder.Entity<Program>()
                .Property(e => e.domeniu_studii)
                .IsUnicode(false);

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
