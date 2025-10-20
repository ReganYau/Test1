using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW1_template
{
    public class Product
    {
        private int productID;
        private string name;
        private double price;
        private int quantity;
        

        public int ProductID
        {
            get { return productID; }
            private set { productID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public Product(int productID, string name, double price, int quantity)
        {
            this.ProductID = productID;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"Product ID {productID}");
            Console.WriteLine($"Product Name {name}");
            Console.WriteLine($"Product Price {price}");
            Console.WriteLine($"Product Quantity {quantity}");
        }

      public void CheapestProduct(Product p1, Product p2)
        {
            if (p1.price < p2.price)
            {
                Console.WriteLine($"£ {p1}");
            }
            else
            {
                Console.WriteLine($"£ {p2}");
            }
        }
            
    }
}
