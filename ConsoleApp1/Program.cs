using System;
﻿using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string rePoli;
            string poli = Console.ReadLine();
            Regex.Replace(poli, "(?i)[^А-ЯЁA-Z]", "");
            //poli = poli.Replace(" ", "").Replace(",", "").Replace(".", "").Replace("!", "").Replace("?", "").Replace(";", "").Replace(":", "").Replace("-", "");
            poli = poli.ToLower();

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
