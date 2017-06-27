using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop2
{
    public class MainCourse : Meal
    {
        public enum CousineType { georgian, ukrainian, french, NA };
        public CousineType cousineType;

        override public string GetGoodsTypeName()
        {
            return "MainCourse";
        }
        override public string[] CollectGoodsProperties()
        {
            return CommonUtils.AddAdditionalString(base.CollectGoodsProperties(), "CousineType: " + cousineType);
        }

    }
}
