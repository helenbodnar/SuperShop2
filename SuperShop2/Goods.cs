using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop2
{
    public abstract class Goods
    {
        private string name = string.Empty;
        private float price = 0;
        public virtual string[] CollectGoodsProperties()
        {
            string goodsDisplayType = "Goods Type:" + GetGoodsTypeName();
            string goodsDisplayName = "Name: " + name;
            string goodsDisplayPrice = "Price: " + price;
            string[] goodsMethods = { goodsDisplayType, goodsDisplayName, goodsDisplayPrice };
            return goodsMethods;
        }
        public virtual void ConsoleWriteGoodsProperties()
        {
            foreach (var goodsProperty in CollectGoodsProperties())
            {
                Console.WriteLine(goodsProperty);
            }
        }

        public abstract string GetGoodsTypeName();
        public override string ToString() // for display goods type:Book, Dessert, Drink, MainCourse
        {
            return GetGoodsTypeName();
        }

        public string GetName()
        {
            return name;
        }
        public float GetPrice()
        {
            return price;
        }
        public void SetName(String a)
        {
            name = a;
        }

        public void SetPrice(float a)
        {
            if (a < 0)
                throw new Exception();
            else
                price = a;
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
    }
}
