

using olderTask.Data.Interfaces;

using olderTask.Models;
using olderTask.Models.ControlUesrs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace olderTask.Data.Repositories
{
    public class ImangerRepository : mangerRepository
    {
        private readonly DBCOUNT _appDbContext;
        private readonly ShoppingCart _shoppingCart;


        public ImangerRepository(DBCOUNT appDbContext )
        {
            _appDbContext = appDbContext;
            
        }


        public void CreateOrder(all all)
        {

            _appDbContext.allUseers.Add(all);

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new Order()
                {
                    id = all.id,
                    FirstName = all.Name,
                    Email = all.Email,

                };

                _appDbContext.Order.Add(orderDetail);
            }

            _appDbContext.SaveChanges();
        }
        public void CreateOrder(rejected rejected)
        {

            _appDbContext.Rejecteds.Add(rejected);

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new Order()
                {
                    id = rejected.id,
                    FirstName = rejected.Name,
                    Email = rejected.Email,

                };

                _appDbContext.Order.Add(orderDetail);
            }

            _appDbContext.SaveChanges();
        }
        public void CreateOrder(painds painds)
        {

            _appDbContext.Painds.Add(painds);

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new Order()
                {
                    id = painds.id,
                    FirstName = painds.Name,
                    Email = painds.Email,

                };

                _appDbContext.Order.Add(orderDetail);
            }

            _appDbContext.SaveChanges();
        }
        public void CreateOrder(approved approved)
        {

            _appDbContext.Approveds.Add(approved);

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new Order()
                {
                    id = approved.id,
                    FirstName = approved.Name,
                    Email = approved.Email,

                };

                _appDbContext.Order.Add(orderDetail);
            }

            _appDbContext.SaveChanges();
        }
        public void CreateOrder(finish finish)
        {

            _appDbContext.Finishes.Add(finish);

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new Order()
                {
                    id = finish.id,
                    FirstName = finish.Name,
                    Email = finish.Email,

                };

                _appDbContext.Order.Add(orderDetail);
            }

            _appDbContext.SaveChanges();
        }
    }

}
