using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _06OctoberAssignement_Adomvc_modelBinding.Models
{
    public class MemberModel
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }

        public DateTime Account_open_Date { get; set; }
        public int MaxBooks { get; set; }

        public int PenaltyAmount { get; set; }


    }
}