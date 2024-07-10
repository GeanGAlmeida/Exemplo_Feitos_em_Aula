using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploLacoFor
{
    internal class ExemploForeach2
    {
        public static void Main(string[] args)
        {
            string[] nome_pessoa = {"iissaacckkii","januario","seu zé do pé de jaca","joão loko","enzzo de lucas"};
            foreach(string count in nome_pessoa)
            {
                Console.WriteLine(count);
            }
        }
    }
}
