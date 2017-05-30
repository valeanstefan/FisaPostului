namespace FisaPostului.Domain.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("continuturi")]
    public partial class continuturi
    {
        [Key]
        public int id_continut { get; set; }

        public int? id_disciplina { get; set; }

        [StringLength(100)]
        public string curs { get; set; }

        [StringLength(100)]
        public string bibliografie { get; set; }

        [StringLength(100)]
        public string semninar { get; set; }

        [StringLength(100)]
        public string laborator { get; set; }

        [StringLength(100)]
        public string proiect { get; set; }
    }
}
