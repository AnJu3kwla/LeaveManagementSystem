using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LeaveManagementWebAPI.Models;
using System.Net.Http;

namespace LeaveManagementWebAPI.Controllers
{
    public class EmpController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(empDetail insertEmp)
        {
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44306/api/LeaveManagement");

            //inserting the record
            var insertRecord = hc.PostAsJsonAsync<empDetail>("LeaveManagement", insertEmp);
            insertRecord.Wait();

            var saveData = insertRecord.Result;

            if (saveData.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View("Create");
        }

        // GET: Emp
        public ActionResult Index()
        {
            IEnumerable<leaveType>leaveTypeObj= null;
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44306/api/LeaveManagement");

            //consume the created api
            var consumeApi = hc.GetAsync("LeaveManagement");
            consumeApi.Wait();

            //reading data
            var readData = consumeApi.Result;

            //if data is read successfully from the api, display them
            if (readData.IsSuccessStatusCode)
            {
                var displayData = readData.Content.ReadAsAsync<IList<leaveType>>();
                displayData.Wait();

                leaveTypeObj = displayData.Result;
            }
            return View(leaveTypeObj);
        }
                
    }
       
}