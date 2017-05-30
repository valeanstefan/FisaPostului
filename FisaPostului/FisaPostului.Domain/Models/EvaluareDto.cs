using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FisaPostului.Domain.Models
{
    public class EvaluareDto
    {
        public int? tip_activitate { get; set; }

        public string criterii { get; set; }

        public string metode { get; set; }

        public int? pondere_nota_finala { get; set; }

        public int id_evaluare { get; set; }
    }
}