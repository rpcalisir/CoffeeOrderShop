namespace CoffeeShopOrder.Core.Interface
{
    public interface IAddition
    {
        string AdditionName { get; set; }
        decimal AdditionPrice { get; set; }
        int AdditionQuantity { get; set; }
    }
}