using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid(); //Guid gera um valor randomico
            id.ToString();

            Console.Clear();
            id = new Guid("c703e6ce-5ff0-46f7-83b7-6f080e8b3275");
            id.ToString().Substring(0, 8);
            Console.WriteLine(id.ToString().Substring(0, 8));
        }






    }
}