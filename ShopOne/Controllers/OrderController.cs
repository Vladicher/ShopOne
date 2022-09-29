using Microsoft.AspNetCore.Mvc;
using ShopOne.Date.Moduls;
using ShopOne.Date;
using ShopOne.Date.Interfaces;

namespace ShopOne.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrder allOrder;
        private readonly ShoCart shoCart;

        public OrderController(IAllOrder allOrder, ShoCart shoCart)
        {
            this.allOrder = allOrder;
            this.shoCart = shoCart;
        }

        public IActionResult CheckOut()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CheckOut(Order order)
        {
            shoCart.listShopItems = shoCart.getShopItems();
            if(shoCart.listShopItems.Count == 0)
            {
                ModelState.AddModelError("", "У вас должны быть товары");
            }
            if(ModelState.IsValid)
            {
                allOrder.CreatorOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);
        }

        public IActionResult Complete ()
        {
            ViewBag.Message = "Заказ успешно обработан";
            return View();
        }
    }
}
