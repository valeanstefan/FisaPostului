using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FisaPostului.Domain.Models
{
    public class TipEvaluareDto
    {
        public int? id_evaluare { get; set; }

        public int? id_disciplina { get; set; }

        public int? tip_activitate { get; set; }

        public string standard_minim_performanta { get; set; }

        public int id_tip_evaluare { get; set; }
    }
}