using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploLacoFor
{
    internal class ExemploArrayMudandoValores
    {
        public static void Main(string[] args)
        {
            string[] car = { "Volvo", "BMW", "Ford", "Mazda" };
            car[0] = "Porche";
            Console.WriteLine(car[0]);
        }
    }
}
