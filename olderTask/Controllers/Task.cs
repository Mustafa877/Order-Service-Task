

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
            var result = DB.Olders.OrderByDescending(x => x.id).ToList();
            return View(result);
        }
  
        public ViewResult main_olderPage()
        {
            
            var result =DB.Olders.OrderByDescending(x => x.id).ToList();
            return View(result);
        }
        public IActionResult olders_List()
        {
            return View();

        }
        public IActionResult oldermanger()
        {
            var result = DB.Order.OrderByDescending(x => x.id).ToList();
            return View(result);
           

        }
        
        public IActionResult Cart()
        {
            //OLDERS c = DB.Olders.Find(id);
            //ViewBag.cat = c.subject;
            //ViewBag.pr = c.price;
            //var result = DB.Olders.OrderByDescending(x => x.id).ToList();
            //return View(result);

            return View();
        }
      
        public IActionResult Editsubject()
        {
            return View();
        }
        
        public IActionResult deleteSubject(int id)
        {
            var subject = DB.Olders.Find(id);
            DB.Olders.Remove(subject);
            DB.SaveChanges();
            return RedirectToAction("ViewSubject"); ;
        }
        [HttpPost]
        public IActionResult savecountion(OLDERS model)
        {
            DB.Olders.Add(model);
            DB.SaveChanges();
            return RedirectToAction("AddSubject");
        }
        [HttpPost]
        //public IActionResult savetocart(cratdb model)
        //{
        //    DB.cratdbs.Add(model);
        //    DB.SaveChanges();
        //    return RedirectToAction("AddSubject");
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
