using Microsoft.AspNetCore.Mvc;
using ShopOne.Date.Interfaces;
using ShopOne.Date.Moduls;
using ShopOne.ViewModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ShopOne.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategory;

        public CarsController(IAllCars iallCars, ICarsCategory iCategory)
        {
            _allCars = iallCars;
            _allCategory = iCategory;
        }
        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category, IEnumerable<Car> cars)
        {
            string _category = category;
            IEnumerable<Car> car;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("electro", _category, StringComparison.OrdinalIgnoreCase))
                {
                    car = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Электромобили")).OrderBy(i => i.Id);
                    currCategory = "Электромобили";
                }
                else if (string.Equals("fuel", _category, StringComparison.OrdinalIgnoreCase))
                {
                    car = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Классические автомобили")).OrderBy(i => i.Id);
                    currCategory = "Классические автомобили";

                }
                

            }
            
            var carObj = new CarsListModel
            {
                getAllCars = cars,
                currCategory = currCategory
            };
            ViewBag.Title = "Страница с автомобилями";
            return View(carObj);
            
        }
    }
}
