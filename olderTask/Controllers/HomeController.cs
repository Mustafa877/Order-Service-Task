
using DrinkAndGo.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using olderTask.Data.Repositories;
using olderTask.Models;

//using olderTask.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
//using System.Web.Mvc;

namespace olderTask.Controllers
{
    //[SessionExpire]
    public class HomeController : Controller
    {
        DBCOUNT DB;

        public HomeController(DBCOUNT DATEDB)
        {
            DB = DATEDB;
        }
  
        public ViewResult index()
        {
            var result = DB.Subjects.OrderByDescending(x => x.id).ToList();
            return View(result);
            //return View();
        }
    }
}