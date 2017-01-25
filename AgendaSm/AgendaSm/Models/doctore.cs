namespace AgendaSm.Models
{
  using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Data.Entity;

    [Table("agendasm.doctores")]

   
        #region DatosAutomaticos
    public partial class doctore
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public doctore()
        {
            consultas = new HashSet<consulta>();
        }

        [Key]
        public long id_doctor { get; set; }

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
        [StringLength(50)]
        public string sCedula { get; set; }

        //public bool? bSexo { get; set; }
        [Required]
        [StringLength(5)]
        public string sSexo { get; set; }

        public TimeSpan? tHentrada { get; set; }

        public TimeSpan? tHsalida { get; set; }

        [Column(TypeName = "date")]
        public DateTime dtFecnac { get; set; }

        [Required]
        [StringLength(50)]
        public string sTelefono { get; set; }

        public bool? bStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<consulta> consultas { get; set; }

    #endregion
        
        #region Codigo Guardar Medicos
        public void Guardar(doctore nDoctor)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    if (nDoctor.id_doctor > 0)
                    {
                        ctx.Entry(nDoctor).State = EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(nDoctor).State = EntityState.Added;
                    }
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Listar datos Doctores
        public List<doctore> getAll(Boolean status)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.doctores.Where(r => r.bStatus == status).ToList();
                }
            }
            catch (Exception) { throw; }
        }
#endregion


    }
}
