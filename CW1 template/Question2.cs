using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW1_template
{
    public class Question2
    {
        public static void question2()
        {
            // Question 2:
            Console.WriteLine("\n-------Question 2-------");
            // Enter code and comments here...

            for (int i = 0; i < 50; i++)
            {
                int result = i % 3;
                if (result == 0)
                {
                    Console.WriteLine($"{result}");
                }

            }
        }
    }
}

