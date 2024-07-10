using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploLacoFor
{
    internal class ExemploArrayLength
    {
        public static void Main(string[] args)
        {
            //string[] car = { "Volvo", "BMW", "Ford", "Mazda" };
            //Console.WriteLine(car.Length);
            // Criar um vetor de inteiros
            int[] vetor = new int[3];

            // Adicionar itens ao vetor
            vetor[0] = 10;
            vetor[1] = 20;
            vetor[2] = 30;

            // Redimensionar o vetor para adicionar mais um item
            Array.Resize(ref vetor, vetor.Length + 1);

            // Adicionar um novo item ao vetor
            vetor[vetor.Length - 1] = 40;

            // Iterar sobre o vetor e imprimir os itens
            foreach (int item in vetor)
            {
                Console.WriteLine(item);
            }
        }
    }
}
