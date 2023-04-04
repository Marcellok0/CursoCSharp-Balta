using System;

namespace Adicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "ESte TExto é Um TEste";

            Console.WriteLine(texto);

            // ToLower <= Converte o texto todo para minúsculo
            Console.WriteLine(texto.ToLower());


            // ToUpper <= Converte o texto todo para maiúsculo
            Console.WriteLine(texto.ToUpper());

            // Insert( posição, "texto") <= Insere um texto no local indicado
            Console.WriteLine(texto.Insert(11, "AQui "));

            // Insert( posição, "texto") <= Insere um texto no local indicado
            Console.WriteLine(texto.Remove(13, 2));

            // Length <= trás a quantidade de caracteres que o texto tem
            Console.WriteLine(texto.Length);

        }
    }
}