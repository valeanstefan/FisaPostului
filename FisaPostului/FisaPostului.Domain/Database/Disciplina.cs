namespace FisaPostului.Domain.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Disciplina
    {
        [StringLength(100)]
        public string denumirea_disciplinei { get; set; }

        [StringLength(50)]
        public string codul_disciplinei { get; set; }

        [StringLength(100)]
        public string titular_activitati_curs { get; set; }

        [StringLength(100)]
        public string titularul_activitati_aplicatii { get; set; }

        public int? an_studiu { get; set; }

        [StringLength(30)]
        public string semestru { get; set; }

        [StringLength(100)]
        public string tip_evaluare { get; set; }

        [StringLength(20)]
        public string regimul_disciplinei { get; set; }

        [Key]
        public int id_disciplina { get; set; }
    }
}
