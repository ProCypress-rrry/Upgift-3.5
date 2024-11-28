using System;
using System.ComponentModel.Design;
namespace Upgift3_5
{
   class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv 2 nummer");
            int tal = int.Parse(Console.ReadLine());
            int TAL = int.Parse(Console.ReadLine());
            while (tal != 0 && TAL != 0)
            {
                int ad = TAL + tal;
                int mi = TAL - tal;
                int di = TAL / tal;
                int mu = TAL * tal;
                Console.WriteLine("välj ochså det räkne sätt du skulle velja använda");
                string abc = Console.ReadLine();
                if (abc == "+")
                    Console.WriteLine(ad);
                else if (abc == "-")
                Console.WriteLine(mi);
                else if (abc == "/")
                Console.WriteLine(di);
                else if (abc == "*")
                Console.WriteLine(mu);
                else 
                    Console.WriteLine("tyvär exsisterar inte " + abc + " i mitt program");
                break;
            }
        }
    }
}