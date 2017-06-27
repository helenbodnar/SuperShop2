﻿using System;
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

        override public List<string> CollectGoodsProperties()
        {
            List<string> collectGoodsProperties = base.CollectGoodsProperties();
            collectGoodsProperties.Add("Callories: " + Callories.ToString());
            collectGoodsProperties.Add("Weight: " + Weight.ToString());
            return collectGoodsProperties;
        }
    }

}
