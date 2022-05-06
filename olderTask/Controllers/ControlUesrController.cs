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
        private ShoppingCart _shoppingCart;

        public ControlUesrController(ImangerRepository mangerRepository, ShoppingCart shoppingCart)
        {
            _mangerRepository = mangerRepository;
            _shoppingCart = shoppingCart;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        ////[Authorize]
        public IActionResult oldermanger(rejected rejected)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your card is empty, add some olders first");
            }

            //
            if (ModelState.IsValid)
            {
                _mangerRepository.CreateOrder(rejected);
                _shoppingCart.ClearCart();
                //return RedirectToAction("/Task/oldermanger");
            }
            return View(rejected);
        }
 




        






















        //public IActionResult PushFinish(finish finish)
        //{

        //    _mangerRepository.CreateOrder(finish);

        //    return RedirectToAction("/Task/admindashbord");

        //}
        //public IActionResult PushApproved(approved approved)
        //{

        //    _mangerRepository.CreateOrder(approved);

        //    return RedirectToAction("/Task/admindashbord");

        //}
        //public IActionResult PushAll(all all)
        //{

        //    _mangerRepository.CreateOrder(all);

        //    return RedirectToAction("/Task/admindashbord");

        //}
        //public IActionResult PushPainds(painds painds)
        //{

        //    _mangerRepository.CreateOrder(painds);

        //    return RedirectToAction("/Task/admindashbord");

        //}
    }
}
