using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopOne.Date.Moduls
{
    public class Car
    {
        public int Id { get; set; } //id товара
        public string name { get; set; } // имя товара
        public string shortDesc { get; set; } // короткое описание
        public string longDesc { get; set; } // длинное описание
        public string img { get; set; } // URL картинки
        public ushort price { get; set; } // цена на товар
        public bool isFavorite { get; set; } // Товар на главной страничке
        public bool avallable { get; set; } // есть ли товар на складе
        public int categoryID { get; set; } // присваивают объект к данной категории
        public virtual Category Category { get; set; } //К какой категории относится данный товар

    }
}
