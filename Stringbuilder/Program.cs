using System;
using System.Text;

namespace Stringbuilder
{

    class Program
    {

        static void Main(string[] args)
        {
            var texto = new StringBuilder();
            texto.Append("Este texto é um teste");
            texto.Append("este é um teste");
            texto.Append("Este texto");
            texto.Append("Este um teste");

            
            texto.ToString();
            Console.WriteLine(texto);


        }








    }






}