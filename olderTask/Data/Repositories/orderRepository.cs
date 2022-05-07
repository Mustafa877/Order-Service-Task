

using olderTask.Data.Interfaces;

using olderTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace olderTask.Data.Repositories
{
    public class orderRepository : IOrderRepository
    {
        private readonly DBCOUNT _appDbContext;
        private readonly ShoppingCart _shoppingCart;


        public orderRepository(DBCOUNT appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }


        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            _appDbContext.Orders.Add(order);

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Amount = shoppingCartItem.Amount,
                    SubjectId = shoppingCartItem.Subject.Subjectid,
                    subject = shoppingCartItem.Subject.subject,
                    OrderId = order.OrderId,
                    Price = shoppingCartItem.Subject.price
                };

                _appDbContext.OrderDetail.Add(orderDetail);
            }

            _appDbContext.SaveChanges();
        }
    }

}
