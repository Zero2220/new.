using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2,-4,-2 };

            reverse(a);

             for (int i = 0; i < a.Length; i++)
             {

                Console.WriteLine(a[i]);

             }


        }


        //Verilmiş ədədlər siyahısının bütün elementlərini  müsbət şəkildə qaytaran metod. Misalçün  metoda {1,-4,9,-8}
        //dəyərləri olan array göndərilsə metod bizə {1,4,9,8} dəyərləri olan array qaytarmalıdır.


        static int[] reverse(int[] nums)
        {

            int[] result = new int[nums.Length];


            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i] < 0)
                {
                    nums[i] *= -1;

                    

                }

            }

            return nums;


        }


    }
}
