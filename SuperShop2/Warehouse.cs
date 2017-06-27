using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop2
{
    public class Warehouse
    {
        Goods[] GoodsItems = new Goods[0]; // store here

        public void AddGoods(Goods newItem)
        {
            GoodsItems = AppendGoods(GoodsItems, newItem);
        }
        static public Goods[] AppendGoods(Goods[] goodsCollection, Goods additionalGoods)
        {
            Goods[] newcollection = new Goods[goodsCollection.Length + 1];
            for (int i = 0; i < goodsCollection.Length; i++)
            {
                newcollection[i] = goodsCollection[i];
            }
            newcollection[newcollection.Length - 1] = additionalGoods;

            return newcollection;
        }

        public Goods[] GetAllGoods()
        {
            return GoodsItems;
        }

        public Goods GetGoods(string type, string name)
        {
            Goods[] allGoods = GetAllGoods();
            foreach (var goods in allGoods)
            {
                if (goods.Name == name && goods.GetGoodsTypeName() == type)
                {
                    return goods;
                }
            }

            return null;
        }
        static public Goods[] RemoveGoods(Goods[] goodsCollection, Goods finededGoods)
        {
           
            Goods[] newcollection = new Goods[goodsCollection.Length - 1];

            int newi = 0;
            for (int i = 0; i < goodsCollection.Length; i++)
            {
                if (goodsCollection[i] != finededGoods)
                {
                    newcollection[newi] = goodsCollection[i];
                    newi++;
                }
            }

            return newcollection;
        }

        public Goods DeleteGoods(string type, string name)
        {

            Goods finededGood = GetGoods(type, name);
            if (finededGood == null)
            {
                return null;
            }

            Goods[] allGoods = GetAllGoods();

            GoodsItems = RemoveGoods(allGoods, finededGood);
            return finededGood;

        }
        public Goods DeleteGoods(Goods goodsToDelete)
        {
            goodsToDelete.GetName(); // Avoid nulls
           
            //    if (goodsToDelete == null)
            //   {
            //     return null;
            //}

            Goods[] allGoods = GetAllGoods();

            GoodsItems = RemoveGoods(allGoods, goodsToDelete);
            return goodsToDelete;

        }
    }
}
