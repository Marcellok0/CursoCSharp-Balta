using System;

namespace Stopwatch
{

    class Program
    {
        static void Main(string[] args)
        {

            var price = 10.20;
            //var texto = "O preço do produto é R$" + price + ". Apenas na promoção!";
            //var texto = string.Format("O preço do produto é {0} apenas na promoção", price); //{0} precisa substituir o valor
            var texto = $"O preço do produto é R$ {price}, apenas na promoão";

            //@ <= possibilita a continuação do codigo em outra linha
            // \n <= possibilita a quebra de linha
            //$  <= possibilita a interpolação com a chamada da {var}

            Console.Clear();
            Console.WriteLine(texto);


        }


    }


}
