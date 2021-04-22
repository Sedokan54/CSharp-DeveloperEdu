using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            Database databse = new Oracle();
            databse.Add();
            databse.Delete();

            Database databse2 = new SqlServer();
            databse2.Add();
            databse2.Delete();

            Console.ReadLine();
        }
    }


    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Delete();
    }
    
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by defaultSql");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by defaultOracle");
        }
    }

}
