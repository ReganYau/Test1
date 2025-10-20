using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CW1_template.Product;
namespace CW1_template
{
    public class Question5
    {
        public static void question5()
        {
            // Question 5: 
            Console.WriteLine("\n-------Question 5-------");
            Product p1= new Product("1", "Tablet", "1300.50", "4");
            Product p2= new Product("2", "Smartphone", "712.50", "12");
            Console.WriteLine("Currently available products");
            p1.PrintProduct();
            p2.PrintProduct();
        }
    }
}
