using CoffeeShopOrder.Core.Enum;

namespace CoffeeShopOrder.Business.Interface
{
    public interface IBeverageFactory
    {
        BeverageType GetBeverageType(string beverageType);
    }
}