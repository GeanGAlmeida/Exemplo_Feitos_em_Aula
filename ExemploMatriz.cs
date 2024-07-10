using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploLacoFor
{
    internal class ExemploMatriz
    {
        public static void Main(string[] args)
        {
            int[,] matrix = { { 1, 2, 3, }, { 4, 5, 6 } };
            Console.WriteLine(matrix[0, 2]);
        }
    }
}
