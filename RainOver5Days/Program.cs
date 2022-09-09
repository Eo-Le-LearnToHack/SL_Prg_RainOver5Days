using System;

namespace RainOver5Days
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Rain regn = new(); //Constructor sørger for at brugeren indtaster regnbør over 5 dage, samt beregn gennemsnitsværdien og sammenligner værdien med gns. regnbør i sep.

                if (regn.GetResultComparison() == -2)
                {
                    Console.WriteLine("FEJL I KODEN");
                }
                else if (regn.GetResultComparison() == -1)
                {
                    Console.WriteLine($"{regn.GetRainAverage()} mm er mindre {regn.GetSepAverage()} mm");
                }
                else if (regn.GetResultComparison() == 0)
                {
                    Console.WriteLine($"{regn.GetRainAverage()} mm er lig med {regn.GetSepAverage()} mm");
                }
                else if (regn.GetResultComparison() == 1)
                {
                    Console.WriteLine($"{regn.GetRainAverage()} mm er større end {regn.GetSepAverage()} mm");
                }
                Console.WriteLine("\nTryk på en vilkårlig tast for at prøve igen");
                Console.ReadLine(); 
            }
        }
    }
}

