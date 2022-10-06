using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _06OctoberAssignement_Adomvc_modelBinding.Models
{
    public class ProductModel
    {
        [Required()]
        public int Proid { get; set; }
        [MaxLength(10, ErrorMessage = "Too Lengthy Name")]
        [MinLength(3, ErrorMessage = "Too Short Name")]
        [Required()]
        public string ProdName { get; set; }
        [Required()]
        public int Price { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",ApplyFormatInEditMode =true)]
        public DateTime MfgDate { get; set; }


    }
}