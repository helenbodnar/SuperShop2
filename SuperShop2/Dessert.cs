using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop2
{
    public class Dessert : Meal
    {
        public enum DessertType { Cake, Cookie, IceCream };
        public DessertType dessertType;

        override public string[] CollectGoodsProperties()
        {
            return CommonUtils.AddAdditionalString(base.CollectGoodsProperties(), "Dessert type: " + dessertType);
        }
        override public string GetGoodsTypeName()
        {
            return "Dessert";
        }

    }
}
