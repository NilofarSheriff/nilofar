//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _06OctoberAssignement_Adomvc_modelBinding
{
    using System;
    using System.Collections.Generic;
    
    public partial class Issue_C
    {
        public decimal Lib_Issue_Id { get; set; }
        public Nullable<int> Member_Id { get; set; }
        public Nullable<decimal> Book_No { get; set; }
        public Nullable<System.DateTime> Issue_Date { get; set; }
        public Nullable<System.DateTime> Return_Date { get; set; }
    
        public virtual Book_C Book_C { get; set; }
        public virtual Member_C Member_C { get; set; }
    }
}
