namespace AgendaSm.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("agendasm.usuarios")]
    public partial class usuario
    {
        [Key]
        public long id_usuario { get; set; }

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
        [StringLength(50)]
        public string sUsuario { get; set; }

        [Required]
        [StringLength(100)]
        public string sContraseña { get; set; }

        [Required]
        [StringLength(80)]
        public string sEmail { get; set; }

        [Required]
        [StringLength(50)]
        public string sTipoUser { get; set; }

        public bool? bStatus { get; set; }
    }
}
