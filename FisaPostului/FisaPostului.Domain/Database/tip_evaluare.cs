namespace FisaPostului.Domain.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tip_evaluare
    {
        public int? id_evaluare { get; set; }

        public int? id_disciplina { get; set; }

        public int? tip_activitate { get; set; }

        [StringLength(100)]
        public string standard_minim_performanta { get; set; }

        [Key]
        public int id_tip_evaluare { get; set; }
    }
}
