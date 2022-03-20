using System;

namespace AsalSayiListeleme
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 ' den 10000 ' e kadar bütün asal sayıları listeleme

            int counter = 0;

            for (int i = 2; i < 10000; i++)
            {
                for (int k = 2; k < i; k++)
                {
                    if (i % k == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 0)
                {
                    Console.WriteLine(i);
                }
                counter = 0;
            }
        }
    }
}
