using ShopOne.Date.Moduls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopOne.ViewModel
{
    public class CarsListModel
    {
        public IEnumerable<Car> getAllCars { get; set; }

        public string currCategory { get; set; }
    }
}
