using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using ShopOne.Date.Interfaces;
using ShopOne.Date.Moduls;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ShopOne.Date
{
    public class DbObjects
    {
        public static void initial(AppDBContent content)
        {
            
            
            if (!content.Category.Any())

                content.Category.AddRange(Categories.Select(c => c.Value));
            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "Tesla Model S",
                        shortDesc = "Быстрый, мощный, надежный",
                        longDesc = "Модель S содержит в себе скорость спорткара и комфорт бизнес-класса",
                        img = "/img/tesla model s.jpg",
                        price = 45000,
                        isFavorite = true,
                        avallable = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        name = "Land Rover Range Rover",
                        shortDesc = "Внедорожник представительсого класса",
                        longDesc = "Range Rover это эталон роскоши среди внедорожников",
                        img = "/img/landrover.jpg",
                        price = 65000,
                        isFavorite = true,
                        avallable = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "Ford Focus",
                        shortDesc = "Автомобиль на повседнев",
                        longDesc = "Простой, надежный автомобиль на каждый день",
                        img = "/img/fordfocus.jpg",
                        price = 15000,
                        isFavorite = false,
                        avallable = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "Nissan Teana",
                        shortDesc = "Бизнес от Nissan",
                        longDesc = "Флагман от компании Nissan, комфортный и надежный автомобиль",
                        img = "/img/teana.jpg",
                        price = 25000,
                        isFavorite = false,
                        avallable = false,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "BMW X5 F15",
                        shortDesc = "Быстрый, мощный, лучшая управляемость",
                        longDesc = "X5 это эмоции которые начинаются уже при открытие дверей",
                        img = "/img/x5.jpg",
                        price = 55000,
                        isFavorite = true,
                        avallable = false,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "Lexus IS 200",
                        shortDesc = "Спортивная внешность, дешевизна в обслуживании",
                        longDesc = "Надежность Lexus непоколебима, а на ряду с яркой внешностью...",
                        img = "/img/lexus.jpg",
                        price = 15000,
                        isFavorite = false,
                        avallable = true,
                        Category = Categories["Классические автомобили"]
                    }
                    );
            }
            content.SaveChanges();


        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(categories != null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Электромобили", desc = "Современный вид транспорта"},
                        new Category { categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания"}
                    };
                    categories = new Dictionary<string, Category>();
                    foreach(Category element in list)
                    {
                        categories.Add(element.categoryName, element);
                    }
                }
                return categories;
            }
        }




    }
}
