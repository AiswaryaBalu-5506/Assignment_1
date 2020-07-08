using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HandsOnMVCUsingViewModel.Models;
using HandsOnMVCUsingViewModel.ViewModels;
namespace HandsOnMVCUsingViewModel.Controllers
{
    public class EmployeeController : Controller
    {
        [Route("EmpProjectDetails")]
        public IActionResult Index()
        {
            Project p = new Project() { Pid = "P0001", Pname = "HealthCare" };
            Employee e = new Employee() { Eid = 1, Ename = "Rohan", Pid = "P0001" };
            EmpProject ep = new EmpProject() { Employee = e, Project = p };
            return View(ep);
        }
        [Route("Employee/Details")]
        public IActionResult Details()
        {
            Project p = new Project() { Pid = "P0001", Pname = "HealthCare" };
            Employee e = new Employee() { Eid = 1, Ename = "Rohan", Pid = "P0001" };
            EmpWork ew = new EmpWork() { Eid = e.Eid, Ename = e.Ename, Pname = p.Pname };
            return View(ew);
        }
    }
}
