using System.Collections.Generic;
using System;

namespace ShopOne.Date.Moduls
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }

        public int CarId { get; set; }
        public uint Price { get; set; }
        public virtual Car Car { get; set; }
        public virtual Order Order { get; set; }
        
    }
}
