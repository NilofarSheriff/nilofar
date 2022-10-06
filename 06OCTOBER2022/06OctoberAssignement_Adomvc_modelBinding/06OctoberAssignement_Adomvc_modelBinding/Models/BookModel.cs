using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _06OctoberAssignement_Adomvc_modelBinding.Models
{
    public class BookModel
    {
        [Required()]
        public int BookNo { get; set; }
        public string BookName { get; set; }

        public int Price { get; set; }

        public string Author { get; set; }

        public string Category { get; set; }

    }
}