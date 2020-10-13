using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LeaveManagementWebAPI.Models;

namespace LeaveManagementWebAPI.Controllers
{
    public class LeaveManagementController : ApiController
    {
        EmployeeEntities ee = new EmployeeEntities();

        public IHttpActionResult getLeaveType() {
            //fetching records from the leaveTypes table
            var results = ee.leaveTypes.ToList();
            return Ok(results);
        }

        [HttpPost]
        public IHttpActionResult insertEmp(empDetail empInsert) {
            ee.empDetails.Add(empInsert);
            ee.SaveChanges();
            return Ok();
        }
    }
}
