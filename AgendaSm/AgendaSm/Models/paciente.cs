namespace AgendaSm.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("agendasm.pacientes")]
    public partial class paciente
    {
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

        [Column(TypeName = "date")]
        public DateTime dtFecnac { get; set; }

        [Required]
        [StringLength(50)]
        public string sDerechohabiente { get; set; }

        public bool? bSexo { get; set; }

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
    }
}
