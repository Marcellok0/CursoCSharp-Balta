using System;

namespace Adicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "ESte TExto é Um TEste";

            // Replace <= substitue o texto ou parte dele pelo indicado 
            Console.WriteLine(texto.Replace("ESte", "ISto"));
            Console.WriteLine(texto.Replace("e", "X"));


            // Split <= quebra o texto no local informado
            var divisao = texto.Split(" ");
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);

            var resultado = texto.Substring(5, 5);
            Console.WriteLine(resultado);

            // Trim <= serve para limpar os espaços do inicio e do fim do texto
            Console.WriteLine(texto.Trim());

        }
    }
}