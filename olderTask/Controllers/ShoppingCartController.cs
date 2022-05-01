
using DrinkAndGo.Data.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using olderTask.Data.Interfaces;
using olderTask.Models;
using olderTask.ViewModels;
using System.Linq;


namespace olderTask.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IpickRepository _olderRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IpickRepository olderRepository, ShoppingCart shoppingCart)
        {
            _olderRepository = olderRepository;
            _shoppingCart = shoppingCart;
        }



        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
            //return View();
        }


        public RedirectToActionResult AddToShoppingCart(int OrderId)
        {
            var selectedOlder = _olderRepository.OLDERs.FirstOrDefault(p => p.id == OrderId);
            if (selectedOlder != null)
            {
                _shoppingCart.AddToCart(selectedOlder, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int OrderId)
        {
            var selectedolder = _olderRepository.OLDERs.FirstOrDefault(p => p.id == OrderId);
            if (selectedolder != null)
            {
                _shoppingCart.RemoveFromCart(selectedolder);
            }
            return RedirectToAction("Index");
        }

    }
}
