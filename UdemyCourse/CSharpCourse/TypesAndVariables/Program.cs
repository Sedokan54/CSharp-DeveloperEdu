using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types//      
            double number5 = 10.4; // 64 bit (virgülden sonra 15-16 karakter)
            decimal number6 = 10; // double'nin long'u
            
            bool condition = true;
            char character = 'A';
            string city = "Ankara";

            byte number4 = 255;    // 8 bit (0-255)
            short number3 = 32767; //16 bit
            int number1 = 2147483647;   // 32 bit yer kaplar.
            long number2 = 9223372036854775807;  // 64 bit.

            var number7 = 10; // il atama hangi tür ise(integer vs.) ondan sonraki aynı değişkene atamalar o türde kabul edilir.

            

            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Character is {0}", (int)character);
            Console.WriteLine(Days.Friday);
           
            Console.ReadLine(); 
        }
    }
    
    enum Days    // Başlangıç değerlerini değiştirebiliyoruz. Like Monday=1.
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}   
