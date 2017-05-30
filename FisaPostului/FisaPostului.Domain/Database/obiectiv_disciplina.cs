namespace FisaPostului.Domain.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class obiectiv_disciplina
    {
        [Key]
        public int id_obiectiv { get; set; }

        public int? id_disciplina { get; set; }

        [StringLength(1)]
        public string obiectiv_general { get; set; }

        [StringLength(1)]
        public string obiectiv_specific { get; set; }
    }
}
