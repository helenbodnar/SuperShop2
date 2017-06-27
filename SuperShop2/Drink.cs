using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop2
{
  public  class Drink : Meal
    {
        public float Volume { get; set; }
        override public string GetGoodsTypeName()
        {
            return "Drink";
        }
        override public string[] CollectGoodsProperties()
        {
            return CommonUtils.AddAdditionalString(base.CollectGoodsProperties(), "Volume: " + Volume);
        }
    }
}
