using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 10;

            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }

            else if (number == 20)
            {
                Console.WriteLine("Number is 20");
            }

            else
            {
                Console.WriteLine("Number is not 10 or 20");
            }

            Console.ReadLine();



            // Yukarıdaki if elif else bloğunun tek satırda yazımı:

            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10 or 20");
            Console.ReadLine();

            // Yukarıdaki if elif else bloğunun tek satırda yazımı:



            // Yukarıdaki if elif else bloğunun switch versiyonunda yazımı:

            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("Number is 10");
            //        break;
            //    case 20:
            //        Console.WriteLine("Number is 20");
            //        break;
            //    default:
            //        Console.WriteLine("Number is not 10 or 20");
            //        break;
            //        // Yukarıdaki if elif else bloğunun switch versiyonunda yazımı:


            if (number >= 0 && number <= 100)
            {
                Console.WriteLine("Number is between 0-100");
            }
            else if(number > 100 && number <= 200)
            {
                Console.WriteLine("Number is between 100-200");
            }
            else if (number > 200 || number < 0)
            {
                Console.WriteLine("Number is less than 0 or greater than 200");
            }
            Console.ReadLine();
            

            // iç içe if'leri yazmıcam.
        }
    }
}
