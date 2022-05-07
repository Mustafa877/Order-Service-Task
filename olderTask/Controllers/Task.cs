

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using olderTask.Models;
//using olderTask.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace olderTask.Controllers
{
    public class Task : Controller
    {
        DBCOUNT DB;
        
        public Task (DBCOUNT DATEDB)
        {
            DB = DATEDB;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public IActionResult admindashbord()
        {
            return View();
        }

        public IActionResult AddSubject()
        {
            return View();
        }
        public IActionResult ViewSubject()
        {
            var result = DB.Subjects.OrderByDescending(x => x.Subjectid).ToList();
            return View(result);
        }
  
        public IActionResult olders_List()
        {
            return View();

        }
        public IActionResult oldermanger()
        {
            var result = DB.Orders.OrderByDescending(x => x.OrderId).ToList();
            return View(result);
           

        }
        public IActionResult Editsubject()
        {
            return View();
        }
        
        public IActionResult deleteSubject(int id)
        {
            var subject = DB.Subjects.Find(id);
            DB.Subjects.Remove(subject);
            DB.SaveChanges();
            return RedirectToAction("ViewSubject"); ;
        }
        [HttpPost]
        public IActionResult savecountion(Subject model)
        {
            DB.Subjects.Add(model);
            DB.SaveChanges();
            return RedirectToAction("AddSubject");
        }
       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
