using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogretmen ogr = new Ogretmen
            {
                Ad = "Ahmet",
                Soyad = "Öz",
                Brans = "Matematik"
            };
            Ogretmen ogretmen = new Ogretmen
            {
                Ad = "Ahmet",
                Soyad = "Öz",
                Brans = "Matemati"
            };
            OkulPersoneli per = ogr; // !!!
            Console.WriteLine(per.Ad);
        }
    }
    public class OkulPersoneli
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
    public class Ogretmen : OkulPersoneli
    {
        public string Brans { get; set; }
    }
}
