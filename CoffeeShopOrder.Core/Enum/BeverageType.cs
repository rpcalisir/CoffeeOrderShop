using System.ComponentModel.DataAnnotations;

namespace CoffeeShopOrder.Core.Enum
{
    public enum BeverageType
    {
        none,
        [Display(Name = "Black Coffee")]
        blackCoffee,
        [Display(Name = "Latte")]
        latte,
        [Display(Name = "Mocha")]
        mocha,
        [Display(Name = "Tea")]
        tea
    }
}
