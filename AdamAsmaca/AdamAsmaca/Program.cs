using System;

namespace AdamAsmaca
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "kitap", "kalem", "yazılım", "bilgisayar" };
            string selectedWord;
            int life = 5;

            Random rnd = new Random();
            selectedWord = words[rnd.Next(0, words.Length - 1)];

            char[] placeholder = new char[selectedWord.Length];

            for (int i = 0; i < placeholder.Length; i++)
            {
                placeholder[i] = '-';
                Console.Write('-');
            }
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("life:{0}",life);
                Console.WriteLine("enter a letter: ");
                char letter = Convert.ToChar(Console.ReadLine());

                bool flag = false;
                int remainingWord = 0;

                for (int i = 0; i < selectedWord.Length; i++)
                {
                    if (selectedWord[i] == letter)
                    {
                        placeholder[i] = letter;
                        flag = true;
                    }
                    if (placeholder[i] == '-')
                    {
                        remainingWord++;
                    }
                    Console.Write(placeholder[i]);
                }
                Console.WriteLine();

                if (remainingWord == 0)
                {
                    Console.WriteLine("Congratulations :)");
                    break;
                }
                if (flag == false)
                {
                    life--;
                }
                if (life == 0)
                {
                    Console.WriteLine("You Lost :(");
                }
                Console.WriteLine("**********************************");

            }
            Console.WriteLine("Selected Word: {0} ",selectedWord);
        }
    }
}
