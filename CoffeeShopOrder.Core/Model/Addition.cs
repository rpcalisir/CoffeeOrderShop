using CoffeeShopOrder.Core.Interface;

namespace CoffeeShopOrder.Core.Model
{
    public class Addition : IAddition
    {
        public string AdditionName { get; set; }
        public int AdditionQuantity { get; set; }
        public decimal AdditionPrice { get; set; }
    }
}
