namespace FisaPostului.Domain.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ore_tip_activitate
    {
        public int? curs { get; set; }

        public int? laborator { get; set; }

        public int? seminar { get; set; }

        public int? proiect { get; set; }

        [Key]
        public int id_activitate { get; set; }
    }
}
