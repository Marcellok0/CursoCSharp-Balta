using System;


namespace Calculator
{

    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Testando";
            //Compara variaveis afim de determinar semelhança 
            Console.WriteLine(texto.CompareTo("Testando"));
            Console.WriteLine(texto.CompareTo("testando"));


            // Contais <= verifica se contem parte do texto na execução
            Console.WriteLine(texto.Contains("esta"));

            // StringComparison.OrdinalIgnoreCase <= ignora o case sansitive do C#
            Console.WriteLine(texto.Contains("ESTA", StringComparison.OrdinalIgnoreCase));


        }
    }
}