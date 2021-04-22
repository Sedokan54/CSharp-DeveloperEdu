using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //var result = Add2(20, 30);

            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(ref number1, number2);


            Console.WriteLine(result2);
            Console.WriteLine(number1);

            Console.WriteLine(Multiply(2, 4, 6));

            Console.WriteLine(Add4(1, 1, 1, 2, 3, 5, 6, 67));
         

            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(ref int number1, int number2) // ref yerine out da var. Değer atamdan da gönderilior. Genelde ref kullanılır. Out kullanırken üsttekinde np metottakinde olması lazm.
        {
            number1 = 30;
            return number1 + number2;
        }




        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }


        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
        


    }

}
