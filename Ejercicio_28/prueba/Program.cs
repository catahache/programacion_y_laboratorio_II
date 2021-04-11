using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContarPalabras();

            Console.ReadKey();
        }
        public static void ContarPalabras()
        {
            string[] separators = new string[] { ",", ".", "!", "\'", " ", "\'s" };
            string text = "My dog's bone, toy, are missing!";

            foreach (string word in text.Split(separators, StringSplitOptions.RemoveEmptyEntries))
            {
                Console.WriteLine($"{word}");
            }
        }

    }
}
