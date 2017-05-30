using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FisaPostului.Domain.Models
{
    public class ConditiiDto
    {
        public int? id_disciplina { get; set; }
        
        public string curriculum { get; set; }
        
        public string competente { get; set; }
        
        public string desfasurare_curs { get; set; }
        
        public string desfasurare_laborator { get; set; }
        
        public int id_conditie { get; set; }
    }
}