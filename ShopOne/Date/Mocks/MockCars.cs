using ShopOne.Date.Interfaces;
using ShopOne.Date.Moduls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopOne.Date.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _carsCategory = new MockCategory();
        public IEnumerable<Car> Cars 
        {
            get
            {
                return new List<Car>
                {
                    new Car { 
                        name = "Tesla Model S", 
                        shortDesc = "Быстрый, мощный, надежный", 
                        longDesc = "Модель S содержит в себе скорость спорткара и комфорт бизнес-класса",
                        img ="/img/tesla model s.jpg", 
                        price = 45000, 
                        isFavorite = true, 
                        avallable = true, 
                        Category = _carsCategory.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Land Rover Range Rover",
                        shortDesc = "Внедорожник представительсого класса",
                        longDesc = "Range Rover это эталон роскоши среди внедорожников",
                        img ="/img/landrover.jpg",
                        price = 65000,
                        isFavorite = true,
                        avallable = true,
                        Category = _carsCategory.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Ford Focus",
                        shortDesc = "Автомобиль на повседнев",
                        longDesc = "Простой, надежный автомобиль на каждый день",
                        img ="/img/fordfocus.jpg",
                        price = 15000,
                        isFavorite = false,
                        avallable = true,
                        Category = _carsCategory.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Nissan Teana",
                        shortDesc = "Бизнес от Nissan",
                        longDesc = "Флагман от компании Nissan, комфортный и надежный автомобиль",
                        img ="/img/teana.jpg",
                        price = 25000,
                        isFavorite = false,
                        avallable = false,
                        Category = _carsCategory.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "BMW X5 F15",
                        shortDesc = "Быстрый, мощный, лучшая управляемость",
                        longDesc = "X5 это эмоции которые начинаются уже при открытие дверей",
                        img ="/img/x5.jpg",
                        price = 55000,
                        isFavorite = true,
                        avallable = false,
                        Category = _carsCategory.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Lexus IS 200",
                        shortDesc = "Спортивная внешность, дешевизна в обслуживании",
                        longDesc = "Надежность Lexus непоколебима, а на ряду с яркой внешностью...",
                        img ="/img/lexus.jpg",
                        price = 35000,
                        isFavorite = false,
                        avallable = true,
                        Category = _carsCategory.AllCategories.Last()
                    }
                };
            }
                set => throw new NotImplementedException(); }
        public IEnumerable<Car> GetCars { get; set; }

        public Car getObjectCar(int carud)
        {
            throw new NotImplementedException();
        }
    }
}
