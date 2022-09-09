using System;

public class Rain
{
	private const int sepAverage = 75; //Rain in mm //NB! Const doesnt work with "this."
    private List<int> lsInMm = new();
    private int RainAverage { get; set; }
    private int RainTotal { get; set; }
    private int RainTemp { get; set; }
    private int counter = 1;
    private int resultComparison = -2; //error code


    public Rain()
	{
        this.ReadUserInput();
        this.CalcRainAverage();
        this.resultComparison = this.CompareRainAverageVsSepAverage();
    }


    public void UdskrivSammenligningsresultat()
    {
        if (this.resultComparison == -2)
        {
            Console.WriteLine("FEJL I KODEN");
        }
        else if (this.resultComparison == -1)
        {
            Console.WriteLine($"Dit gennemsnit {this.RainAverage} mm er mindre gennemsnittet i september måned {sepAverage} mm");
        }
        else if (this.resultComparison == 0)
        {
            Console.WriteLine($"Dit gennemsnit {this.RainAverage} mm er lig med gennemsnittet i september måned {sepAverage} mm");
        }
        else if (this.resultComparison == 1)
        {
            Console.WriteLine($"Dit gennemsnit {this.RainAverage} mm er større end gennemsnittet i september måned {sepAverage} mm");
        }
    }

    private void ReadUserInput()
    {
        Console.WriteLine("Indtast mængden af regnbør over 5 dage.\n");
        do
        {
            try
            {
                Console.Write($"Dag {counter}: Indtast mængden af regnbør i mm :");
                this.RainTemp = int.Parse(Console.ReadLine());
                this.lsInMm.Add(this.RainTemp);
                this.RainTotal += this.RainTemp;
                counter++;
            }
            catch (Exception)
            {
            }
        } while (counter < 6);
    }


    private void CalcRainAverage()
    {
        this.RainAverage = this.RainTotal / this.lsInMm.Count;
    }


    private int CompareRainAverageVsSepAverage()
    {
        int result = -2; //error code

        if (this.RainAverage < sepAverage)
        {
            result = - 1;
        }
        else if (this.RainAverage == sepAverage)
        {
            result = 0;
        }
        else if (this.RainAverage > sepAverage)
        {
            result = 1;
        }
        return result;
    }

}