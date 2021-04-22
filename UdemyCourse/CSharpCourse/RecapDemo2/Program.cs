using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customermanager = new CustomerManager();
            customermanager.Logger = new DatabaseLogger();

            customermanager.Add();
            Console.ReadLine();
        }



        class CustomerManager
        {

            public ILogger Logger { get; set; }
            public void Add()
            {
                Logger.Log();
                Console.WriteLine("Customer Added");
            }
        }

        interface ILogger
        {
            void Log();
        }

        class DatabaseLogger: ILogger
        {
            public void Log()
            {
                Console.WriteLine("Logged to database");
            }
        }

        class FileLogger : ILogger
        {
            public void Log()
            {
                Console.WriteLine("Logged to file");
            }
        }        
    }
}
