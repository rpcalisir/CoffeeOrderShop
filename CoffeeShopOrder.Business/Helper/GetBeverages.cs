using CoffeeShopOrder.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopOrder.Business.Helper
{
    public static class GetBeverages
    {
        public static List<string> GetAllBeverages()
        {
            List<string> beverageNames = new List<string>();
            foreach (BeverageType beverageEnum in Enum.GetValues(typeof(BeverageType)))
            {
                beverageNames.Add(beverageEnum.GetDescription().ToString());
            }
            return beverageNames;
        }
        private static string GetDescription(this Enum GenericEnum)
        {

            Type genericEnumType = GenericEnum.GetType();
            System.Reflection.MemberInfo[] memberInfo =
                        genericEnumType.GetMember(GenericEnum.ToString());

            if ((memberInfo != null && memberInfo.Length > 0))
            {

                dynamic _Attribs = memberInfo[0].GetCustomAttributes
                      (typeof(System.ComponentModel.DescriptionAttribute), false);
                if ((_Attribs != null && _Attribs.Length > 0))
                {
                    return ((System.ComponentModel.DescriptionAttribute)_Attribs[0]).Description;
                }
            }

            return GenericEnum.ToString();
        }
    }
}
