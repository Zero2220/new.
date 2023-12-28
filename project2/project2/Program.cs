using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = numberSymbols("lalala");


            Console.WriteLine(a);
        }

        //Verilmiş yazıdaki verilmiş simvolların sayını qaytaran metod
        static int numberSymbols(string text )
        {


            int count = 0;



            for ( int i = 0; i < text.Length; i++ )
            {

                    count++;

            }
             return count;
        }
    }
}
