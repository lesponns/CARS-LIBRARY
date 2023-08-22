using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_38_22_08_23_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cars> cars = new List<Cars>();

            Cars a1 = new Cars();
            a1.Marka = "FIAT";
            a1.Model = "EGEA";
            a1.kmh = 308100;
            a1.year = 2015;
            a1.price = 495900;
            cars.Add(a1);

            Cars a2 = new Cars();
            a2.Marka = "TOYOTA";
            a2.Model = "SUPRA MK3";
            a2.kmh = 185000;
            a2.year = 1991;
            a2.price = 3900000;
            cars.Add(a2);

            Cars a3 = new Cars();
            a3.Marka = "MERCEDES - BENZ";
            a3.Model = "G63 AMG";
            a3.kmh = 125000;
            a3.year = 2014;
            a3.price = 7900000;
            cars.Add(a3);

            Cars a4 = new Cars();
            a4.Marka = "BMW";
            a4.Model = "520d M5 SPORT";
            a4.kmh = 290000;
            a4.year = 2008;
            a4.price = 985000;
            cars.Add(a4);

            Cars a5 = new Cars();
            a5.Marka = "Honda";
            a5.Model = "Accord";
            a5.kmh = 41100;
            a5.year = 2021;
            a5.price = 1585000;
            cars.Add(a5);

            foreach (var item in cars) 
            {
                Console.Write("_________________\n\n");
                Console.Write("Marka: {0}\nModel: {1}", item.Marka,item.Model);
                Console.Write("\n_________________\n");
            }



            Console.ReadKey();
        }
    }
}
