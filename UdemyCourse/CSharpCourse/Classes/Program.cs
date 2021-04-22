using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Update();

            ProductManager productManager = new ProductManager();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Kaan Furkan";
            customer.LastName = "Kaya";

            Customer customer2 = new Customer
            {
                Id= 2, City= "Istanbul", FirstName = "Kaan Furkan", LastName = "Kaya"      // Bi üstteki ile aynı görevde ama bu daha kullanışlı.
            };

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }
    
}
