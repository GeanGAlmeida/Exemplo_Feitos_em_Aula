using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploLacoFor
{
    internal class ExemploMudandoElementoMatriz
    {
        public static void Main(string[] args)
        {
            int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 } };
            matriz[0, 2] = 10;
            Console.WriteLine(matriz[0, 2]);
        }
    }
}
