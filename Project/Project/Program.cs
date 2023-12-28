using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = calculator(12,13,'-');

            Console.WriteLine(a);


        }
        //Verilmiş iki ədəd üzərində verilmiş operator simvoluna əsasən
        //riyazi əməliyyat aparıb nəticəsini console-da göstərən metod.

       static int calculator(int eded1, int  eded2,char operatorSimvolu)
       {
            int netice = 0;

            switch (operatorSimvolu)
            {
                case '+':
                    netice = eded1 + eded2;
                    break;
                case '-':
                    netice = eded1 - eded2;
                    break;
                case '*':
                    netice = eded1 * eded2;
                    break;
                case '/':
                    if (eded2 != 0)
                    {
                        netice = eded1 / eded2;
                    }
                    else
                    {
                        Console.WriteLine("Xəta: Bölmə 0-a bölünmə mümkün deyil.");
                    }
                    break;
                default:
                    Console.WriteLine("Xəta: Yanlış operator simvolu daxil edildi.");
                    break;
            }

            return netice;
        }


    }
    
}
