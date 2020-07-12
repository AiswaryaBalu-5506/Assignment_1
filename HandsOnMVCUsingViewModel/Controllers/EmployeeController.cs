using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HandsOnMVCUsingViewModel.Models;
using HandsOnMVCUsingViewModel.ViewModels;
using HandsOnMVCUsingViewModel.Repositories;

namespace HandsOnMVCUsingViewModel.Controllers
{
    public class EmployeeController : Controller
    {


        /* [Route("EmpProjectDetails")]
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
} */


        //How to call EmployeeRepository.cs here?????? You dependency inject the IEmployeeRepository
        //Create an object of type IEmployeeRepository.
        private IEmployeeRepository _empRepo;
        public EmployeeController(IEmployeeRepository empRepo)
        {
            _empRepo = empRepo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewData["Title"] = "This is Index Page of Employee Controller";
            return View(_empRepo.GetAllEmployees());
        }

        [HttpGet]
        public IActionResult Details()
        {
            Employee ep = _empRepo.GetEmpById(1);
            return View(ep);
        }





    }
}



