using Microsoft.AspNetCore.Mvc;
using olderTask.Data.Interfaces;
using olderTask.Data.Repositories;
using olderTask.Models;
using olderTask.Models.ControlUesrs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace olderTask.Controllers
{
    public class ControlUesrController : Controller
    {
        private mangerRepository _mangerRepository;

        public ControlUesrController(ImangerRepository mangerRepository)
        {
            _mangerRepository = mangerRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
       
        [HttpPost]
        ////[Authorize]
        public IActionResult PushRejected(rejected rejected)
        {

            _mangerRepository.CreateOrder(rejected);

            return RedirectToAction("/Task/admindashbord");

        }
        public IActionResult PushFinish(finish finish)
        {

            _mangerRepository.CreateOrder(finish);

            return RedirectToAction("/Task/admindashbord");

        }
        public IActionResult PushApproved(approved approved)
        {

            _mangerRepository.CreateOrder(approved);

            return RedirectToAction("/Task/admindashbord");

        }
        public IActionResult PushAll(all all)
        {

            _mangerRepository.CreateOrder(all);

            return RedirectToAction("/Task/admindashbord");

        }
        public IActionResult PushPainds(painds painds)
        {
            
            _mangerRepository.CreateOrder(painds);

            return RedirectToAction("/Task/admindashbord");

        }
    }
}
