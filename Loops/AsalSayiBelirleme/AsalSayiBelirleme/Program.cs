using System;

namespace AsalSayiBelirleme
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcının girdiği sayının asal olup olmama durumunu belirleme

            Console.WriteLine("Enter Number: ");
            int number = Convert.ToInt32(Console.ReadLine());


            int counter = 0;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    counter++;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine(number +" "+"is a prime number :)");
            }
            else
            {
                Console.WriteLine(number + " " +"is not a prime number :(");
            }




        }
    }
}
