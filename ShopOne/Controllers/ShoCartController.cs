using Microsoft.AspNetCore.Mvc;
using ShopOne.Date.Interfaces;
using ShopOne.Date.Moduls;
using ShopOne.Date.Repository;
using ShopOne.ViewModel;
using System.Linq;

namespace ShopOne.Controllers
{
    public class ShoCartController : Controller
    {
        private IAllCars _carRep;
        private readonly ShoCart _shoCart;

        public ShoCartController(IAllCars carRep, ShoCart shoCart)
        {
            _carRep = carRep;
            _shoCart = shoCart;
        }
        public ViewResult Index()
        {
            var items = _shoCart.getShopItems();
            _shoCart.listShopItems = items;

            var obj = new ShoCartNewModuls
            {
                shoCart = _shoCart,
            };
            return View(obj);
        }

        public RedirectToActionResult addToCar(int id)
        {
            var item = _carRep.Cars.FirstOrDefault(i => i.Id == id);
            if(item != null)
            {
                _shoCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
