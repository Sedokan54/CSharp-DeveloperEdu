using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    public delegate void MyDelegate();
    public delegate void MyDelegate1(string text);
    public delegate int MyDelegate2(int number1, int number2);

    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();
           

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;

            myDelegate -= customerManager.SendMessage;

            MyDelegate1 myDelegate1 = customerManager.SendMessage1;
            myDelegate1 += customerManager.ShowAlert1;

            Matematik matematik = new Matematik();
            MyDelegate2 myDelegate2 = matematik.Topla;
            myDelegate2 += matematik.Carp;

            var result = myDelegate2(2, 3);
            Console.WriteLine(result);

            myDelegate1("Hello");

            myDelegate();

            Console.ReadLine();
        }
    }








    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be Careful!");
        }

        public void SendMessage1(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowAlert1(string alert)
        {
            Console.WriteLine(alert);
        }
    }

    public class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
