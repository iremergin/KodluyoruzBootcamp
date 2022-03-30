using System;
using System.Collections.Generic;
using System.Linq;
namespace ListCity
{
    class Program
    {
        static void Main(string[] args)
        {
            //Koleksiyonda bulunan elemanların tekrarsız bir şekilde ekrana yazdırılmasını sağlayan program.

            List<string> cities = new List<string>() { "Ankara", "Ankara", "Ankara", "Sinop", "İstanbul", "İstanbul", "Eskişehir", "Ankara" };

            //Distinct Metodu -> Koleksiyonda bulunan elemanların tekrarsız bir şekilde ekrana yazdırılmasını sağlar.

            List<string> listCity = cities.Distinct().ToList();

            foreach (string city in listCity)
            {
                Console.WriteLine(city);
            }

        }
    }
}
