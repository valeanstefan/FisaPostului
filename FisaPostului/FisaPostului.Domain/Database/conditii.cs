namespace FisaPostului.Domain.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("conditii")]
    public partial class conditii
    {
        public int? id_disciplina { get; set; }

        [StringLength(1)]
        public string curriculum { get; set; }

        [StringLength(1)]
        public string competente { get; set; }

        [StringLength(1)]
        public string desfasurare_curs { get; set; }

        [StringLength(1)]
        public string desfasurare_laborator { get; set; }

        [Key]
        public int id_conditie { get; set; }
    }
}
