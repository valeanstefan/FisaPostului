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

        public virtual DbSet<conditii> conditii { get; set; }
        public virtual DbSet<continuturi> continuturi { get; set; }
        public virtual DbSet<Disciplina> date_disciplina { get; set; }
        public virtual DbSet<Program> date_program { get; set; }
        public virtual DbSet<evaluare> evaluare { get; set; }
        public virtual DbSet<obiectiv_disciplina> obiectiv_disciplina { get; set; }
        public virtual DbSet<ore_tip_activitate> ore_tip_activitate { get; set; }
        public virtual DbSet<repartizare_ore> repartizare_ore { get; set; }
        public virtual DbSet<timp_total_estimat> timp_total_estimat { get; set; }
        public virtual DbSet<tip_evaluare> tip_evaluare { get; set; }
        public virtual DbSet<Users> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<conditii>()
                .Property(e => e.curriculum)
                .IsUnicode(false);

            modelBuilder.Entity<conditii>()
                .Property(e => e.competente)
                .IsUnicode(false);

            modelBuilder.Entity<conditii>()
                .Property(e => e.desfasurare_curs)
                .IsUnicode(false);

            modelBuilder.Entity<conditii>()
                .Property(e => e.desfasurare_laborator)
                .IsUnicode(false);

            modelBuilder.Entity<continuturi>()
                .Property(e => e.curs)
                .IsUnicode(false);

            modelBuilder.Entity<continuturi>()
                .Property(e => e.bibliografie)
                .IsUnicode(false);

            modelBuilder.Entity<continuturi>()
                .Property(e => e.semninar)
                .IsUnicode(false);

            modelBuilder.Entity<continuturi>()
                .Property(e => e.laborator)
                .IsUnicode(false);

            modelBuilder.Entity<continuturi>()
                .Property(e => e.proiect)
                .IsUnicode(false);

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

            modelBuilder.Entity<evaluare>()
                .Property(e => e.criterii)
                .IsUnicode(false);

            modelBuilder.Entity<evaluare>()
                .Property(e => e.metode)
                .IsUnicode(false);

            modelBuilder.Entity<obiectiv_disciplina>()
                .Property(e => e.obiectiv_general)
                .IsUnicode(false);

            modelBuilder.Entity<obiectiv_disciplina>()
                .Property(e => e.obiectiv_specific)
                .IsUnicode(false);

            modelBuilder.Entity<repartizare_ore>()
                .Property(e => e.descriere_activitate)
                .IsUnicode(false);

            modelBuilder.Entity<tip_evaluare>()
                .Property(e => e.standard_minim_performanta)
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
