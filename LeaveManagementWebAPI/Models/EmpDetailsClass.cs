using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeaveManagementWebAPI.Models
{
    public class EmpDetailsClass
    {
        public int empCode { get; set; }
        public string empName { get; set; }
        public string supervisorName { get; set; }
        public string leavePackage { get; set; }
    }
}