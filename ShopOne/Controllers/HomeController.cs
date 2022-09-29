using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ShopOne.Date.Interfaces;
using ShopOne.Date.Moduls;
using ShopOne.ViewModel;


namespace ShopOne.Controllers
{
    public class HomeController : Controller
    {
        private IAllCars _carRep;


        public HomeController(IAllCars carRep, ShoCart shoCart)
        {
            _carRep = carRep;
        }
        public ViewResult Index()
        {
            var homeCars = new HomeViewModels
            {
                favCar = _carRep.GetCars
            };
            return View(homeCars);
        }
    }
}
