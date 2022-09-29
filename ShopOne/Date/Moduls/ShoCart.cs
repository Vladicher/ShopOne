using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ShopOne.Date.Moduls
{
    public class ShoCart 
    {
        private readonly AppDBContent appDBContent;

        public ShoCart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public string ShopCartId { get; set; }
        public List<ShopCartItem> listShopItems { get; set; }

        public static ShoCart GetCart(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = service.GetService<AppDBContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShoCart(context)
            {
                ShopCartId = shopCartId
            };
        }
        public void AddToCart(Car car)
        {
            appDBContent.ShopCartItems.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                car = car,
                price = car.price
            });

            appDBContent.SaveChanges();
        }
        public List<ShopCartItem> getShopItems()
        {
            return appDBContent.ShopCartItems.Where(c => c.ShopCartId == ShopCartId).Include(s => s.car).ToList();
        }
    }
}
