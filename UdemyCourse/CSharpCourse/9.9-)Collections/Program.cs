using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _9._9__Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //List();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("Computer", "Bilgisayar");

            Console.WriteLine(dictionary["table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
            }

            dictionary.ContainsKey("book");

            //dictionary de bir kolekisyondur.










            Console.ReadLine();
        }

        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("Istanbul");

            Console.WriteLine(cities.Contains("Ankara "));

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "Kaan" });
            //customers.Add(new Customer { Id = 2, FirstName = "Furkan" });



            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Kaan" },          // Üstteki Böyle de yazılabilir.
                new Customer { Id = 2, FirstName = "Furkan" }
            };

            var count = customers.Count;
            var customer1 = new Customer
            {
                Id = 3,
                FirstName = "Salih"
            };

            customers.Add(customer1);
            customers.AddRange(new Customer[2]
            {
                new Customer{Id=4, FirstName="Ali" },
                new Customer{Id=5, FirstName="Ayşe"}
            });

            Console.WriteLine(customers.Contains(customer1));

            //customers.Clear();

            var index = customers.IndexOf(customer1);
            Console.WriteLine("Index : {0}", index);

            customers.Insert(0, customer1);               // istedğimiz indexe eleman ekleriz
            customers.Remove(customer1);                 // Bulduğu ilkini remove'lar

            customers.RemoveAll(c => c.FirstName == "Salih");




            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
        }




        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");

            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add("A");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //Console.WriteLine(cities[2]);
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
