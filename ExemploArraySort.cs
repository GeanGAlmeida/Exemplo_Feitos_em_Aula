using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploLacoFor
{
    internal class ExemploArraySort
    {
        public static void Main(string[] args)
        {
            string[] car = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(car);
            foreach (string i in car)
            {
                Console.WriteLine(i);
            }
            int[] myNumbers = { 22, 13, 12, 56 };
            Array.Sort(myNumbers);
            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
