using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5
{
    internal class Program
    {
        static void Main(string[] args)
        {



            int a = result(2, 3);


            Console.WriteLine(a);
        }


        //Verilmiş ədədi verilmiş qüvvətə yüksəldib nəticəsini qaytaran metod


        static int result(int x,int y)
        {


            int result1 = 1;


            for (int i = 0; i < y; i++)
            {


                result1 *= x;

            }

            return result1;

        }

    }
}
