using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperShop2;

namespace UnitTestProject1
{
    [TestClass]
    public class SuperShopTest
    {

        [TestMethod]
        public void TestGetGoodsTypeName()
        {
            //Arrange
            Dessert dessert = new Dessert();
            string expected = "Dessert";

            //Act          
            string actual = dessert.GetGoodsTypeName();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCollectGoodsProperties()
        {
            //Arrange

            string[] expectedGoodsProp = { "Goods Type:Dessert", "Name: Plombir", "Price: 12", "Callories: 1000", "Weight: 20", "Dessert type: IceCream" };

            //Act          
            Dessert dessert = new Dessert();
            dessert.SetName("Plombir");
            dessert.SetPrice(12f);
            dessert.dessertType = Dessert.DessertType.IceCream;
            dessert.Callories = 1000;
            dessert.Weight = 20;


            string[] actualGoodsProp = dessert.CollectGoodsProperties();

            //Assert
            for (int i = 0; i < expectedGoodsProp.Length; i++)
            {
                Assert.AreEqual(expectedGoodsProp[i], actualGoodsProp[i]);
            }

        }

        [TestMethod]
        public void TestAddGetAllGoods()
        {
            //Arrange
            Dessert dessert = new Dessert();
            dessert.SetName("Plombir");
            dessert.SetPrice(12f);
            dessert.dessertType = Dessert.DessertType.IceCream;
            dessert.Callories = 1000;
            dessert.Weight = 20;

            //Act  
            Warehouse warehouse = new Warehouse();
            warehouse.AddGoods(dessert);
            Goods[] expectedGoods = warehouse.GetAllGoods();

            // Assert
            Assert.AreEqual(expectedGoods[0], dessert);
        }

        [TestMethod]
        public void TestAddGood()
        {
            //Arrange
            Dessert dessert = new Dessert();
            dessert.SetName("Plombir");
            dessert.SetPrice(12f);
            dessert.dessertType = Dessert.DessertType.IceCream;
            dessert.Callories = 1000;
            dessert.Weight = 20;
            Dessert newdessert = new Dessert();
            newdessert = dessert;

            //Act  
            Warehouse warehouse = new Warehouse();
            warehouse.AddGoods(dessert);
            warehouse.AddGoods(newdessert);

            Goods[] expectedGoods = warehouse.GetAllGoods();

            // Assert
            Assert.AreEqual(expectedGoods.Length, 2);
        }

        [TestMethod]
        public void TestDeleteGoods()
        {
            Dessert dessert = new Dessert();
            dessert.SetName("Plombir");
            dessert.SetPrice(12f);
            dessert.dessertType = Dessert.DessertType.IceCream;
            dessert.Callories = 1000;
            dessert.Weight = 20;

            Dessert newdessert = new Dessert();
            newdessert.dessertType = Dessert.DessertType.IceCream;
            newdessert.SetName("Eskimo");

            Warehouse warehouse = new Warehouse();
            warehouse.AddGoods(dessert);
            warehouse.AddGoods(newdessert);

            Goods[] allGoods = warehouse.GetAllGoods();
            Goods deletedItem = warehouse.DeleteGoods(dessert);
            Assert.AreEqual(deletedItem.Name, dessert.Name);
            Assert.AreEqual(warehouse.GetAllGoods().Length, 1);
        }
       
        [TestMethod]
        public void TestGetGoods()
        {
            Dessert dessert = new Dessert();
            dessert.SetName("Plombir");
            dessert.SetPrice(12f);
            dessert.dessertType = Dessert.DessertType.IceCream;
            dessert.Callories = 1000;
            dessert.Weight = 20;

            MainCourse maincourse = new MainCourse();
            maincourse.SetPrice(120f);

            Warehouse warehouse = new Warehouse();
            warehouse.AddGoods(dessert);
            warehouse.AddGoods(maincourse);

            string type = "Dessert";
            string name = "Plombir";
            Goods findedgood = warehouse.GetGoods(type, name);

            Assert.AreEqual(findedgood.GetPrice(), 12f);
        }
        
    }
}

