using CoffeeShopOrder.Core.Enum;
using CoffeeShopOrder.Core.Interface;

namespace CoffeeShopOrder.Core.Model
{
    public class Addition : IAddition
    {
        public AdditionType AdditionName { get; set; }
        public int AdditionQuantity { get; set; }
        public decimal AdditionPrice { get; set; }
    }
}
