using System;
using System.Collections;
using System.Threading.Channels;

namespace ListeUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            var sehirler = new List<string>()
            {
                "Istanbul",
                "Ordu",
                "Sinop",
                "Kastamonu"
            };

            //Lambda expression
            sehirler.ForEach(s => Console.WriteLine(s));

            Console.WriteLine(new string ('-',50));

            var iller = sehirler;
            iller.ForEach(i => Console.WriteLine(i));

            sehirler.Add("Diyarbakır");
            iller.Add("Muş");
            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Şehirler");
            Console.WriteLine(new string('-', 8));

            sehirler.ForEach(s=> Console.WriteLine(s));
            Console.WriteLine(new string('-', 50));

            Console.WriteLine("İller");
            Console.WriteLine(new string('-', 5));
            iller.ForEach(i => Console.WriteLine(i));

            sehirler.Remove("Istanbul");
            Console.WriteLine();

            iller.ForEach(i=>Console.WriteLine(i));


            Console.ReadKey();
        }
    }
}
