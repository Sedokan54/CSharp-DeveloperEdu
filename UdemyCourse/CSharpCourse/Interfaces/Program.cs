using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterFacesIntro();

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[2] 
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterFacesIntro()
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id = 1, FirstName = "Kaan", LastName = "Kaya", Address = "Istanbul" });
            manager.Add(new Student { Id = 1, FirstName = "Freddie", LastName = "Mercury", Departmant = "Music" });
            manager.Add(new Worker { Id = 1, FirstName = "Mahmut", LastName = "Telli", Departmant = "Imalatci" });
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public string Address { get; set; }

    }

    class Student: IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }

    class PersonManager
    {
        //public void Add(Customer customer)
        //{
        //    Console.WriteLine(customer.FirstName);
        //}

        //public void Add(Student student)
        //{
        //    Console.WriteLine(student.FirstName);
        //}

        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }

    }
}
