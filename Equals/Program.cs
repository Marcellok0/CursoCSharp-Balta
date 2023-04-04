using System;

namespace SartWith
{
    class Program
    {
        static void Main(string[] args)
        {

            var texto = "este texto é um teste";

            // Equals <= veirfica se o texto é identico a info desejada, responde true/false
            Console.WriteLine(texto.Equals("este texto é um teste"));
            Console.WriteLine(texto.Equals("teste texto é um teste"));


            // ", StringComparison.OrdinalIgnoreCase <= IGNORA  maiusculas e minusculas para validar se o texto é igual
            Console.WriteLine(texto.Equals("ESTE TEXTO É UM TESTE", StringComparison.OrdinalIgnoreCase));

        }
    }
}