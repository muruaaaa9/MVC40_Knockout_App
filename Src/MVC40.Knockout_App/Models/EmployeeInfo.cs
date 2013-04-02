using System;
using System.Collections.Generic;

namespace MVC40.Knockout_App.Models
{
    public partial class EmployeeInfo
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public decimal Salary { get; set; }
        public string DeptName { get; set; }
        public string Designation { get; set; }
    }
}
