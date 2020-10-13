using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeaveManagementWebAPI.Models
{
    public class LeaveDetailsClass
    {
        public string employeeName { get; set; }
        public int year { get; set; }
        public string leaveType { get; set; }
        public int entitledLeaves { get; set; }
        public int utilizedLeaves { get; set; }

    }
}