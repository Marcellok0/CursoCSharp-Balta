using System;

namespace SartWith
{
    class Program
    {
        static void Main(string[] args)
        {

            var texto = "este texto é um teste";

            // StartWith <= veirfica se o texto começa com a info desejada, responde true/false
            Console.WriteLine(texto.StartsWith("Este"));
            Console.WriteLine(texto.StartsWith("este"));
            Console.WriteLine(texto.StartsWith("Texto"));

            //EndsWith <= verifica se o texto termina com a info desejada, responde true/false

            Console.WriteLine(texto.EndsWith("Teste"));
            Console.WriteLine(texto.EndsWith("teste"));
            Console.WriteLine(texto.EndsWith("te"));


        }
    }
}