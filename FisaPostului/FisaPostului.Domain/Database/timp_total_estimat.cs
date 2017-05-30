namespace FisaPostului.Domain.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class timp_total_estimat
    {
        public int? id_disciplina { get; set; }

        public int? numar_ore_saptamana { get; set; }

        public int? toal_ore_plan { get; set; }

        public int? total_ore_studiu { get; set; }

        public int? total_ore_semestru { get; set; }

        public short? numar_credite { get; set; }

        [Key]
        public int id_tte { get; set; }
    }
}
