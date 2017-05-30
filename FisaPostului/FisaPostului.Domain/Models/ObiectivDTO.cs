using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FisaPostului.Domain.Models
{
    public class ObiectivDTO
    {
        public int id_obiectiv { get; set; }

        public int? id_disciplina { get; set; }

        public string obiectiv_general { get; set; }

        public string obiectiv_specific { get; set; }

    }
}