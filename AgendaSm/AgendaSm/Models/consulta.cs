namespace AgendaSm.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("agendasm.consultas")]
    public partial class consulta
    {
        [Key]
        public long id_consulta { get; set; }

        public TimeSpan tHora { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha { get; set; }

        public bool? bStatus { get; set; }

        public long pk_paciente { get; set; }

        public long pk_doctor { get; set; }

        [Required]
        [StringLength(50)]
        public string sConsulta { get; set; }

        public virtual paciente paciente { get; set; }

        public virtual doctore doctore { get; set; }
    }
}
