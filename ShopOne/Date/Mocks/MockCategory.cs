using ShopOne.Date.Interfaces;
using ShopOne.Date.Moduls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopOne.Date.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Электромобили", desc = "Современный вид транспорта"},
                    new Category { categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания"}
                };
            }
        }
    }
}
