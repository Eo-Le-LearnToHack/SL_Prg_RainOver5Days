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
                regn.UdskrivSammenligningsresultat();
                ExitProgram lukNed = new(); //Constructor sørger for at lukke ned ved tryk på Esc
            }
        }
    }
}

