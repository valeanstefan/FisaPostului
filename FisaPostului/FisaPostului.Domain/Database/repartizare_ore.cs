namespace FisaPostului.Domain.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class repartizare_ore
    {
        [Key]
        public int activitate_id { get; set; }

        public int? id_disciplina { get; set; }

        [StringLength(100)]
        public string descriere_activitate { get; set; }

        public int? total_ore { get; set; }
    }
}
