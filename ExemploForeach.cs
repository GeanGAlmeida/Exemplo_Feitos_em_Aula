using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploLacoFor
{
    internal class ExemploForeach
    {
        public static void Main(string[] args)
        {
            string[] carro = {"uno","apolo","kwid","onix" };
            foreach (string count in carro) {
                Console.WriteLine(count);
            }
         }
    }
}
