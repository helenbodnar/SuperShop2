using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dessert dessert = new Dessert();
           // Meal meal = dessert;

            dessert.Name = "Plombir"; // desert.SetName("Plombir");
            dessert.SetPrice(12f);
            dessert.dessertType = Dessert.DessertType.IceCream;
            dessert.ConsoleWriteGoodsProperties();
            Console.WriteLine("******");

            Goods newgood = dessert; //Copy one goods to anoyher
            newgood.ConsoleWriteGoodsProperties();
            Console.WriteLine("******");

            Drink drink = new Drink();
            drink.SetName("Apple");

            Book book = new Book();
            book.SetName("Pravda");
            book.SetPrice(2f);
            book.bookType = Book.BookType.newspaper;

            Goods[] order = { dessert, newgood, drink, book }; // Display all list
            PrintOrder(order);

            Drink newdrink = new Drink(); //  set aditional items
            newdrink.SetName("Orange");

            MainCourse maincourse = new MainCourse();
            maincourse.SetName("Borsch");
            maincourse.SetPrice(28f);
            maincourse.cousineType = MainCourse.CousineType.ukrainian;
            maincourse.Callories = 400;

            Warehouse warehouse = new Warehouse();
            warehouse.AddGoods(drink);
            warehouse.AddGoods(dessert);
            warehouse.AddGoods(newdrink);
            warehouse.AddGoods(book);
            warehouse.AddGoods(maincourse);

            Console.WriteLine("============WAREHOSE ALL==========");
            PrintOrder(warehouse.GetAllGoods());

            Console.WriteLine("============WAREHOSE FINDED AND UPDATED PRICE ==========");
            string name = "Plombir";
            string type = "Dessert";
            Goods findedgood = warehouse.GetGoods(type, name);
            if (findedgood != null)
            {
                findedgood.SetPrice(findedgood.GetPrice() + 10);
            }
            else
            {
                Console.WriteLine("Price is not changed. The requested item is not found.");
                Console.WriteLine("*********");
            }
            PrintOrder(warehouse.GetAllGoods());

            Console.WriteLine("============WAREHOSE AFTER DELETION ==========");
            Goods deletedgood = warehouse.DeleteGoods(type, name);
            PrintOrder(warehouse.GetAllGoods());

            Console.WriteLine("============WAREHOSE AFTER NULL PASS ==========");
            try
            {
                warehouse.DeleteGoods(null);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Null is not allowed");
                //    throw;
            }
            PrintOrder(warehouse.GetAllGoods());

            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }

        static void PrintOrder(Goods[] order)
        {
            foreach (Goods g in order)
            {
                g.ConsoleWriteGoodsProperties();
                Console.WriteLine("#: " + g.ToString());
                Console.WriteLine("=======");
            }
        }
    }
}
