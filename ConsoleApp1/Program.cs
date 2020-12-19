using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string rePoli;
            string poli = Console.ReadLine();
            poli = poli.ToLower();
            foreach (var sChar in poli)
            {
                if (Char.IsLetter(sChar) == false)
                {
                    poli = poli.Replace(sChar, '~');
                }
            }
            poli = poli.Replace("~", "");

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
