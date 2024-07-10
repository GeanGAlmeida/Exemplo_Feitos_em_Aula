using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploLacoFor
{
    internal class ExemploForeachMatriz
    {
        public static void Main(string[] args)
        {
            int[,] matrix = { { 1, 5, 7 }, { 2, 10, 8 } };

            foreach (var item in matrix)
            {
                Console.WriteLine(item);
            }
        }
    }
}
