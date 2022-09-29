using ShopOne.Date.Moduls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopOne.Date.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> GetCars { get; }
        Car getObjectCar(int carId);
    }
}
