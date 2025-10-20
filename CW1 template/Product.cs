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
        private string v1;
        private string v2;
        private string v3;
        private string v4;

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
            this.productID = productID;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public Product(string v1, string v2, string v3, string v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
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
            if (p1 < p2)
            {
                Console.WriteLine($"£ {p1} ");
            }
            else
            {
                Console.WriteLine($"£ {p2}");
            }
        }
    }
}
