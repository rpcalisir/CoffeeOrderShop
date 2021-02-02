using CoffeeShopOrder.Core.Enum;

namespace CoffeeShopOrder.Business.Interface
{
    public interface IAdditionFactory
    {
        AdditionType GetBeverageType(string additionType);
    }
}