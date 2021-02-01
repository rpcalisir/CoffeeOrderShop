using CoffeeShopOrder.Core.Enum;

namespace CoffeeShopOrder.Core.Interface
{
    public interface IAddition
    {
        AdditionType AdditionName { get; set; }
        int AdditionQuantity { get; set; }
        decimal AdditionPrice { get; set; }
    }
}