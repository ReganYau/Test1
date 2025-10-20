using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW1_template
{
    public class Question1
    {
        public static void question1()
        {
            // Question 1: 
            Console.WriteLine("-------Question 1-------");
            // Enter code and comments here...

           
        }



        // Returns a character array populated with the alphabet (upper case letters)
        static char[] GetAlphabet()
        {
            char[] alphabet = new char[26];
            for (int i = 65; i <= 90; i++)
            {
                alphabet[i - 65] = (char)i;
            }
            return alphabet;
        }

    }
}
