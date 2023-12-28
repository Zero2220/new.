using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = sum(124);

            Console.WriteLine(a);
        }

        //Verilmiş edədin rəqəmləri cəmini qaytaran metod


       
      

        static int sum(int num)
        {
            int total = 0;
            while (0 < num)
            {
                total += num % 10;
                
                num -= num % 10;
                num /= 10;






            }
            return total;


        }




    }
}
