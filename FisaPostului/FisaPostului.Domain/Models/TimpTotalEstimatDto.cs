using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FisaPostului.Domain.Models
{
    public class TimpTotalEstimatDto
    {
        public int? id_disciplina { get; set; }

        public int? numar_ore_saptamana { get; set; }

        public int? toal_ore_plan { get; set; }

        public int? total_ore_studiu { get; set; }

        public int? total_ore_semestru { get; set; }

        public short? numar_credite { get; set; }

        public int id_tte { get; set; }
    }
}