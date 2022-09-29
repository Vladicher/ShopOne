using ShopOne.Date.Interfaces;
using ShopOne.Date.Moduls;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ShopOne.Date.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent appDBContent;
        public CarRepository(AppDBContent appDBContent, IEnumerable<Car> getCars)
        {
            this.appDBContent = appDBContent;
            
        }

        public IEnumerable<Car> Cars => appDBContent.Car.Include(c => c.Category);

        public IEnumerable<Car> GetCars => appDBContent.Car.Where(p => p.isFavorite).Include(c => c.Category);

        public Car getObjectCar(int carId) => appDBContent.Car.FirstOrDefault(p => p.Id == carId);
    }
}
