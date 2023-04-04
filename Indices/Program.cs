using System;

namespace SartWith
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "este texto é um teste";

            // .IndexOf <= informa a primeira posição específica da info desejada (char/palavra)
            Console.WriteLine(texto.IndexOf("é"));

            // .LastIndexOf informa a ultima posição da info desejada
            Console.WriteLine(texto.LastIndexOf("t"));


        }
    }
}