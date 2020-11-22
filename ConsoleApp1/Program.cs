using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string rePoli;
            string poli = Console.ReadLine();
            poli = poli.Replace(" ", "").Replace(",", "").Replace(".", "").Replace("!", "").Replace("?", "").Replace(";", "").Replace(":", "").Replace("-", "");

            char[] sRev = poli.ToCharArray();
            Array.Reverse(sRev);
            rePoli = new string(sRev);

            Console.WriteLine(
                rePoli == poli
                ? "Строка - палиндром"
                : "Ну строка, как строка (не палиндром)"
            );
        }
    }
}