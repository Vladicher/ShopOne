using ShopOne.Date.Interfaces;
using ShopOne.Date.Moduls;
using System;

namespace ShopOne.Date.Repository
{
    public class OrderRepository : IAllOrder
    {
        private readonly AppDBContent appDBContent;
        private readonly ShoCart shoCart;

        public OrderRepository(AppDBContent appDBContent, ShoCart shoCart)
        {
            this.appDBContent = appDBContent;
            this.shoCart = shoCart;
        }

        public void CreatorOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            appDBContent.Order.Add(order);

            var items = shoCart.listShopItems;

            foreach(var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    CarId = el.car.Id,
                    OrderId = order.Id,
                    Price = el.car.price
                };
                appDBContent.OrderDetail.Add(orderDetail);   
            }
            appDBContent.SaveChanges();
        }
    }
}
