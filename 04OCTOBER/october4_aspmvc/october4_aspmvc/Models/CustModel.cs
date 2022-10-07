using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace october4_aspmvc.Models
{
    public class CustModel
    {
        [Required()]
        public int CustId { get; set; }
        [MaxLength(8,ErrorMessage ="Too lengthy")]
        [MinLength(3,ErrorMessage ="Too short")]
        public string CustName { get; set; }
        [Required()]
        public string City { get; set; }
    }
}