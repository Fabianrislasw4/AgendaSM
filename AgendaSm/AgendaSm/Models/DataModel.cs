namespace AgendaSm.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataModel")
        {
        }

        public virtual DbSet<consulta> consultas { get; set; }
        public virtual DbSet<doctore> doctores { get; set; }
        public virtual DbSet<paciente> pacientes { get; set; }
        public virtual DbSet<usuario> usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<consulta>()
                .Property(e => e.sConsulta)
                .IsUnicode(false);

            modelBuilder.Entity<doctore>()
                .Property(e => e.sNombre)
                .IsUnicode(false);

            modelBuilder.Entity<doctore>()
                .Property(e => e.sApaterno)
                .IsUnicode(false);

            modelBuilder.Entity<doctore>()
                .Property(e => e.sAmaterno)
                .IsUnicode(false);

            modelBuilder.Entity<doctore>()
                .Property(e => e.sCurp)
                .IsUnicode(false);

            modelBuilder.Entity<doctore>()
                .Property(e => e.sCedula)
                .IsUnicode(false);

            modelBuilder.Entity<doctore>()
                .Property(e => e.sTelefono)
                .IsUnicode(false);

            modelBuilder.Entity<doctore>()
                .HasMany(e => e.consultas)
                .WithRequired(e => e.doctore)
                .HasForeignKey(e => e.pk_doctor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<paciente>()
                .Property(e => e.sNombre)
                .IsUnicode(false);

            modelBuilder.Entity<paciente>()
                .Property(e => e.sApaterno)
                .IsUnicode(false);

            modelBuilder.Entity<paciente>()
                .Property(e => e.sAmaterno)
                .IsUnicode(false);

            modelBuilder.Entity<paciente>()
                .Property(e => e.sCurp)
                .IsUnicode(false);

            modelBuilder.Entity<paciente>()
                .Property(e => e.sDerechohabiente)
                .IsUnicode(false);

            modelBuilder.Entity<paciente>()
                .Property(e => e.sTelEmergencia)
                .IsUnicode(false);

            modelBuilder.Entity<paciente>()
                .Property(e => e.sNexpediente)
                .IsUnicode(false);

            modelBuilder.Entity<paciente>()
                .Property(e => e.sTelefono)
                .IsUnicode(false);

            modelBuilder.Entity<paciente>()
                .HasMany(e => e.consultas)
                .WithRequired(e => e.paciente)
                .HasForeignKey(e => e.pk_paciente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.sNombre)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.sApaterno)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.sAmaterno)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.sUsuario)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.sContraseña)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.sEmail)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.sTipoUser)
                .IsUnicode(false);
        }
    }
}
