using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FisaPostului.Domain.Models
{
    public class ContinuturiDto
    {
        public int id_continut { get; set; }

        public int? id_disciplina { get; set; }

        public string curs { get; set; }
        
        public string bibliografie { get; set; }
        
        public string semninar { get; set; }
        
        public string laborator { get; set; }
        
        public string proiect { get; set; }
    }
}