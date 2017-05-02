namespace FisaPostului.Domain.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Program
    {
        public string institutie_invatamant_superior { get; set; }

        [StringLength(100)]
        public string facultatea { get; set; }

        [StringLength(500)]
        public string departamentul { get; set; }

        [StringLength(50)]
        public string ciclu_studii { get; set; }

        [StringLength(100)]
        public string specializarea { get; set; }

        [Key]
        public int id_program { get; set; }
    }
}
