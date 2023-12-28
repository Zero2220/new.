using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project7
{
    internal class Program
    {
        static void Main(string[] args)
        {



            string text = reverse("Salam");


            Console.WriteLine(text);
        }


        //Verilmiş yazını tərs formada qaytaran metod
        //(Misalçün "salam" göndərilsə metoddan "malas" return ediləcək)


        static string reverse(string text)
        {



            string newText = "";



            for (int i = text.Length -1; i>=0; i--)
            {

                newText += text[i];

            }

            return newText;


        }


    }
}
