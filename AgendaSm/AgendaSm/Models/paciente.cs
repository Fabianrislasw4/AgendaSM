namespace AgendaSm.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Data.Entity;

    [Table("agendasm.pacientes")]
    public partial class paciente
    {
        #region "No mover"
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public paciente()
        {
            consultas = new HashSet<consulta>();
        }

        [Key]
        public long id_paciente { get; set; }

        [Required]
        [StringLength(50)]
        public string sNombre { get; set; }

        [Required]
        [StringLength(50)]
        public string sApaterno { get; set; }

        [Required]
        [StringLength(50)]
        public string sAmaterno { get; set; }

        [Required]
        [StringLength(25)]
        public string sCurp { get; set; }

        [Required]
        [StringLength(5)]
        public string sSexo { get; set; }

        [Column(TypeName = "date")]
        public DateTime dtFecnac { get; set; }

        [Required]
        [StringLength(50)]
        public string sDerechohabiente { get; set; }

       // public bool? bSexo { get; set; }

        public bool? bActivo { get; set; }

        [Required]
        [StringLength(50)]
        public string sTelEmergencia { get; set; }

        [Required]
        [StringLength(50)]
        public string sNexpediente { get; set; }

        [Required]
        [StringLength(50)]
        public string sTelefono { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<consulta> consultas { get; set; }

        #endregion

        public void Guardar(paciente nPaciente)
        {
            try {
                using (var ctx = new DataModel())
                {
                    if (nPaciente.id_paciente > 0)
                    {
                        ctx.Entry(nPaciente).State = EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(nPaciente).State = EntityState.Added;
                    }
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<paciente> getAll(Boolean status)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.pacientes.Where(r => r.bActivo == status).ToList();
                }
            }
            catch (Exception) { throw; }
        }
    }
}
