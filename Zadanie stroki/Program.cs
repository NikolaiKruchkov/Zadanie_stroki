using System;

namespace Zadanie_stroki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение, слова должны быть разделены пробелом, знаки препинания не использовать, затем нажмите Enter");
            string predlogenie = Console.ReadLine();
            string[] massivstr = predlogenie.Split();
            string max = massivstr[0];
            int a = 0;
            int b = 0;

            foreach (string i in massivstr)
            {
                a = max.Length;

                b = i.Length;

                if (a < b)
                {
                    max = i;
                }

            }


            Console.WriteLine("Самым длинным в предложении является слово \"{0}\"", max);
            Console.WriteLine("Спасибо, что использовали нашу пргорамму, для выхода нажмите любую клавишу");

            Console.ReadKey();
        }

    }
}
