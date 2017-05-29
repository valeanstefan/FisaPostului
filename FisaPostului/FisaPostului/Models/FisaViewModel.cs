using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FisaPostului.Models
{
    public class FisaViewModel
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Denumire Disciplina")]
        [StringLength(100)]
        public string denumirea_disciplinei { get; set; }

        [Display(Name = "Cod Disciplina")]
        [StringLength(50)]
        public string codul_disciplinei { get; set; }

        [Display(Name = "Titular Activitati Curs")]
        [StringLength(100)]
        public string titular_activitati_curs { get; set; }

        [Display(Name = "Titular Activitati Aplicatii")]
        [StringLength(100)]
        public string titularul_activitati_aplicatii { get; set; }

        [Display(Name = "An Studiu")]
        public int an_studiu { get; set; }

        [Display(Name = "Semestru")]
        [StringLength(30)]
        public string semestru { get; set; }

        [Display(Name = "Tip Evaluare")]
        [StringLength(100)]
        public string tip_evaluare { get; set; }

        [Display(Name = "Regim Disciplina")]
        [StringLength(20)]
        public string regimul_disciplinei { get; set; }

        [Display(Name = "Institutie Invatamant Superior")]
        public string institutie_invatamant_superior { get; set; }

        [Display(Name = "Facultate")]
        [StringLength(100)]
        public string facultatea { get; set; }

        [Display(Name = "Departament")]
        [StringLength(500)]
        public string departamentul { get; set; }

        [Display(Name = "Ciclul de studii")]
        [StringLength(50)]
        public string ciclu_studii { get; set; }

        [Display(Name = "Domeniul de studiu")]
        [StringLength(50)]
        public string domeniu_studii { get; set; }

        [Display(Name = "Specializare")]
        [StringLength(100)]
        public string specializarea { get; set; }

    }
}