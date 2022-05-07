
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
        private readonly ISubjectRepository _SubjectRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(ISubjectRepository SubjectRepository, ShoppingCart shoppingCart)
        {
            _SubjectRepository = SubjectRepository;
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


        public RedirectToActionResult AddToShoppingCart(int subjectId)
        {
            var selectedOlder = _SubjectRepository.subjects.FirstOrDefault(p => p.Subjectid == subjectId);
            if (selectedOlder != null)
            {
                _shoppingCart.AddToCart(selectedOlder, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int subjectId)
        {
            var selectedolder = _SubjectRepository.subjects.FirstOrDefault(p => p.Subjectid == subjectId);
            if (selectedolder != null)
            {
                _shoppingCart.RemoveFromCart(selectedolder);
            }
            return RedirectToAction("Index");
        }

    }
}
