using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FisaPostului.Domain.Models
{
    public class OreTipActivitateDto
    {
        public int? curs { get; set; }

        public int? laborator { get; set; }

        public int? seminar { get; set; }

        public int? proiect { get; set; }

        public int id_activitate { get; set; }
    }
}