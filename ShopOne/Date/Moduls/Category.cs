using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopOne.Date.Moduls
{
    public class Category
    {
        public int Id { get; set; }

        public string categoryName { get; set; }

        public string desc { get; set; }
        public List<Car> cars { get; set; } //товары которые входят в данную категорию

    }
}
