using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _06OctoberAssignement_Adomvc_modelBinding.Models
{
    public class IssueModel
    {
        [Required()]
        public int IssueId { get; set; }
        public int BookNo { get; set; }

        public int MemberId { get; set; }

        public DateTime Issue_Date { get; set; }

        public DateTime Return_Date { get; set; }
    }
}