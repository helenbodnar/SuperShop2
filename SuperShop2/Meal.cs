using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop2
{
    public abstract class Meal : Goods
    {
        public int Callories { get; set; }
        public float Weight { get; set; }

        override public string[] CollectGoodsProperties()
        {
            string[] mealcollection = CommonUtils.AddAdditionalString(base.CollectGoodsProperties(), "Callories: " + Callories);
            return CommonUtils.AddAdditionalString(mealcollection, "Weight: " + Weight);
        }
    }

}
