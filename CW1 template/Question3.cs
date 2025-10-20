using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW1_template
{
    public class Question3
    {
        public static void question3()
        {
            // Question 3:
            Console.WriteLine("\n-------Question 3-------");
            // Enter code and comments here...
            int num;
            do
            {
                Console.WriteLine("Enter a number (0 to quit): ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 10)
                {
                    Console.WriteLine("The number is greater than 10");
                }
                else if (num < 10)
                {
                    Console.WriteLine("The number is less than 10");
                }
                else if (num == 10)
                {
                    Console.WriteLine("The number is equal to 10");
                }
            } while (num != 0);
           
        }
    }
}
