using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploLacoFor
{
    internal class ExemploArrayMinMaxSum
    {
        public static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(numeros.Max()); //retorna o maior valor
            Console.WriteLine(numeros.Min()); //retorna o menor valor
            Console.WriteLine(numeros.Sum()); //retorna a soma dos valores
            Console.WriteLine(numeros.Average());
        }
    }
}
