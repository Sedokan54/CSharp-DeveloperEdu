using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
        private int id;                           // Burada default "private"tır // Yani: "private int id;"  // Private'lar sadece tanımlandığ blok içinde geçerlidir.

        protected int id1;                        // Private'in bütün özelliklerini kapsar. Protected ile tanımlanan şeyler inherit edilen sınıflarda kullanılabilir.
        public void Save()                      
        {
                                                  // id private ile burada tanımlansaydı sadece bu blokta kullanılabilirdi. // Blok: {}
        }
    }

    class Students:Customer
    {
        public void Save2()
        {
                                               // Private yazamıyoruz ama Protected yazabiliyoruz.
        }
    }


    class Course                                  // Bir class'ın default'u "internal" dır. // Yani: "internal class Course{}" 
    {                                             //İnternal bir class'ı bağlı olduğu assembly içerisinde referans ihtiyacı olmadan kullanabiliriz. // (Yani bulunduğu proje içinde: "AccessModifiers")
        public string name { get; set; } 
    }

    public class Course1
    {
        public string name { get; set; }         // public ile ilgili bilgi için AccesModifiersDemo'ya bak!
    }


}
















// İçi içe class'lar hariç sadece internal ve public olabilirler.

// Kapsama alanına göre;    private < protected < internal < Public