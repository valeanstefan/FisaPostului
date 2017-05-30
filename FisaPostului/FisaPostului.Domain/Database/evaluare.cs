namespace FisaPostului.Domain.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("evaluare")]
    public partial class evaluare
    {
        public int? tip_activitate { get; set; }

        [StringLength(100)]
        public string criterii { get; set; }

        [StringLength(100)]
        public string metode { get; set; }

        public int? pondere_nota_finala { get; set; }

        [Key]
        public int id_evaluare { get; set; }
    }
}
