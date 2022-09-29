using Microsoft.EntityFrameworkCore;
using ShopOne.Date.Interfaces;
using ShopOne.Date.Moduls;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ShopOne.Date.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDBContent appDBContent;
        private readonly IEnumerable<Car> cars;

        public CategoryRepository(AppDBContent appDBContent, IEnumerable<Car> cars)
        {
            this.appDBContent = appDBContent;
            this.cars = cars;
        }
        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
