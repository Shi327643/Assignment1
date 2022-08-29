using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingLibrary
{
    public class Product
    {
        private string productName;

        public string ProductName { 
            get { return productName; } 
            set { productName = value; }
        
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set
            {
                quantity = value;
            }
        }

        public double GetProductCost(int price, int quantity)
        {
            double cost;
            cost = price * quantity;
            return cost;
        }


        public Product(string _productName, double _price, int _quantity)  
        {
           
            ProductName = _productName;
            Price = _price;
            Quantity = _quantity;

        }

        public override string ToString()
        {
            return String.Format($"ProductName : {ProductName} Price : {Price} Quantity : {Quantity}");
        }





    }
}
