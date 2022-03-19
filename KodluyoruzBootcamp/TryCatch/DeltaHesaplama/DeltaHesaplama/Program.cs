using System;

namespace DeltaHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("a: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("b: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("c: ");
                int c = Convert.ToInt32(Console.ReadLine());

                int delta = b * b - 4 * a * c;

                Console.WriteLine("Delta: " + delta);

            }
            catch (System.FormatException)
            {

                Console.WriteLine("Please enter numeric value");
      
                
            }
            

        }
    }
}
