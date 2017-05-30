using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FisaPostului.Domain.Models
{
    public class RepartizareOreDto
    {
        public int activitate_id { get; set; }

        public int? id_disciplina { get; set; }

        public string descriere_activitate { get; set; }

        public int? total_ore { get; set; }
    }
}