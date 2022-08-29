using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopingLibrary;

namespace ShopingTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Product product = new Product("Dove Shampoo",200,10);
            Product product1 = new Product("shampoo",200,5);
            Console.WriteLine(product1);
            Console.WriteLine(product1.ToString());

            Console.WriteLine("*******************************************************************");

            Product product2 = new Product("conditioner", 250, 5);
            Console.WriteLine(product2);
            Console.WriteLine(product2.ToString());

            Console.WriteLine("*******************************************************************");

            Product product3 = new Product("Gel", 100, 5);
            Console.WriteLine(product3);
            Console.WriteLine(product3.ToString());

            Console.WriteLine("*******************************************************************");


            Console.WriteLine("Product1 name is:"+ product1.ProductName);
            Console.WriteLine("Product2 nname is:" + product2.ProductName);
            Console.WriteLine("Product3 name is:" + product3.ProductName);

            Console.WriteLine("*******************************************************************");

            Console.WriteLine("Price1 is:"+product1.Price);
            Console.WriteLine("Price2 is:" + product2.Price);
            Console.WriteLine("Price3 is:" + product3.Price);

            Console.WriteLine("*******************************************************************");

            Console.WriteLine("Product1 Quantity is:" + product2.Quantity);
            Console.WriteLine("Product2 Quantity is:" + product2.Quantity);
            Console.WriteLine("Product3 Quantity is:" + product2.Quantity);
            Console.WriteLine("*******************************************************************");


            Console.WriteLine("cost of product1 is:" + product1.GetProductCost(200, 5));
            Console.WriteLine("cost of product2 is:" + product2.GetProductCost(250, 5));
            Console.WriteLine("cost of product3 is:" + product3.GetProductCost(100, 5));

            Console.ReadLine();

           






        }
    }
}
