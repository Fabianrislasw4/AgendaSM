namespace AgendaSm.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("agendasm.doctores")]
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

        public bool? bSexo { get; set; }

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
    }
}
