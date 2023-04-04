using System;
using System.Globalization;

namespace Data
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var datamarc = new DateTime(1987, 07, 06, 20, 23, 14);
            Console.WriteLine(datamarc);
            Console.WriteLine(datamarc.DayOfWeek);
            var dataju = new DateTime(1997, 09, 20, 20, 23, 14);
            //var data = DateTime.Now; //exibe a data de hoje
            Console.WriteLine(dataju);
            Console.WriteLine(dataju.DayOfWeek);

// d apresenta a menor hora hora
// t exibe a menor data
// f combina data e hr
//g apresenta a menor data e hora 
// r / R data padrão
// s comumente usado no front end

var juformatada = String.Format("{0:dd|MM|yyyy}", dataju);
Console.WriteLine(juformatada);

var pt = new CultureInfo("pt-PT");
var br = new CultureInfo("pt-BR");
var en = new CultureInfo("en-US");
var de = new CultureInfo("de-DE");

Console.WriteLine(DateTime.Now.ToString("D", de));

        }
    }
}