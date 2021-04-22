using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "İzmir","Adana");

            foreach (var res in result)
            {
                Console.WriteLine(res);
            }

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer(), new Customer());

            foreach (var customer in result2)
            {
                Console.WriteLine(customer.FirstName);  
            }

            Console.ReadLine();
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    class Product:IEntity
    {

    }

    interface IProductDal:IRepository<Product>
    {
     
    }

    class Customer:IEntity
    {
        public string FirstName { get; set; }
    }

    interface ICustomerdal: IRepository<Customer>
    {
        
    }

    interface IRepository<T> where T:class, IEntity ,new()
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

    }

    interface IEntity
    {

    }

    class CustomerDal : ICustomerdal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }

    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }


}
