using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploLacoFor
{
    internal class ExemploBreak2
    {
        public static void Main(string[] args)
        {
            string[] nome_pessoa = { "iissaacckkii", "januario","luiz gonzaga", "seu zé do pé de jaca", "joão loko", "enzzo de lucas" };
            foreach (string count in nome_pessoa)
            {
                if (count == "joão loko")
                {
                    break;
                }
                Console.WriteLine(count);
            }
        }
    }
}
