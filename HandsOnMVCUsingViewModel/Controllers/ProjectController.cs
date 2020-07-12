using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HandsOnMVCUsingViewModel.Models;
namespace HandsOnMVCUsingViewModel.Controllers
{
    public class ProjectController : Controller
    {
        public static List<Project> list = new List<Project>()
        {
            new Project() { Pid = "P0001", Pname = "HealthCare" }
         };
       [Route("GetAllProjects")]
        public IActionResult Index()
        {
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Project p)
        {
            //adding project data to list
            list.Add(p);
            return RedirectToAction("Index"); //redirects to Index Action
        }
        [HttpPost]
        public IActionResult Create(string Pid,string Pname)
        {
            //adding project data to list
            list.Add(new Project() { Pid=Pid,Pname=Pname});
            return RedirectToAction("Index"); //redirects to Index Action
        }
    }
}
