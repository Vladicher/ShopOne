using ShopOne.Date.Moduls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopOne.Date.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
