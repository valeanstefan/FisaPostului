using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FisaPostului.Domain.Models
{
    public class ProgramDto
    {
        [Display(Name ="Institutie Invatamant Superior")]
        public string institutie_invatamant_superior { get; set; }
        [Display(Name = "Facultate")]
        [StringLength(100)]
        public string facultatea { get; set; }
        [Display(Name = "Departament")]
        [StringLength(500)]
        public string departamentul { get; set; }
        [Display(Name = "Ciclu Studii")]
        [StringLength(50)]
        public string ciclu_studii { get; set; }
        [Display(Name = "Domeniul de studii")]
        [StringLength(50)]
        public string domeniu_studii { get; set; }
        [Display(Name = "Specializarea")]
        [StringLength(100)]
        public string specializarea { get; set; }

        [Key]
        public int id_program { get; set; }
    }
}