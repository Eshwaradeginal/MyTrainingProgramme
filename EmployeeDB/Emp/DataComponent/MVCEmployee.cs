//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Employee.DataComponent
{
    using System;
    using System.Collections.Generic;
    
    public partial class MVCEmployee
    {
        public int Empid { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public Nullable<decimal> EmpSalary { get; set; }
        public Nullable<int> DeptId { get; set; }
    
        public virtual MVCDepartment MVCDepartment { get; set; }
    }
}
