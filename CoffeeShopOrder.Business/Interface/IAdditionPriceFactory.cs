using CoffeeShopOrder.Core.Enum;

namespace CoffeeShopOrder.Business.Interface
{
    public interface IAdditionPriceFactory
    {
        decimal GetAdditionPrice(AdditionType additionType);
    }
}