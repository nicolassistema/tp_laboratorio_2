using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Numero.BinarioDecimal("1011010101110"));

            Console.WriteLine(Numero.DecimalBinario(10));

            Console.WriteLine(Numero.DecimalBinario("10"));

            Console.WriteLine(10 + 10);
            Console.WriteLine(10 - 10);
            Console.WriteLine(10 / 1);
            Console.WriteLine(10 * 10);
         

            //Console.ReadKey();

        }
    }
}
