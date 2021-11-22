using System;

namespace Zadanie_stroki_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение, слова должны быть разделены пробелом, знаки препинания не использовать, затем нажмите Enter");
            string predlogenie = Console.ReadLine();
            predlogenie.ToLower();
            string bez_probelov = predlogenie.Replace(" ", "");            
            string[] massivstr = bez_probelov.Split();
            int a = massivstr.Length;

            foreach (string i in massivstr)
            {
                if (i == massivstr[a - 1])
                {
                    a -= 1;
                }
            }                  
                
            if  (a==0)
            {
                Console.WriteLine("Предложение является палиндромом");

            }
            else
            {
                Console.WriteLine("Предложение не является палиндромом");
            }
            Console.ReadKey();









        }
    }
}
