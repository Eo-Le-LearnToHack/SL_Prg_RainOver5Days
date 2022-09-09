using System;

public class Rain
{
	private const int sepAverage = 75; //Rain in mm
    private List<int> lsInMm = new();
    private int rainAverage = 0;
    private int rainTotal { get; set; }
    private int rainTemp = 0;
    private int counter = 1;
    private int resultComparison = -2; //error code


    public Rain()
	{
        this.ReadUserInput();
        this.CalcRainAverage();
        this.resultComparison = this.CompareRainAverageVsSepAverage();
    }

	private void ReadUserInput ()
	{
		Console.WriteLine("Indtast mængden af regnbør over 5 dage.\n");
		do
		{
            try
            {
                Console.Write($"Dag {counter}: Indtast mængden af regnbør i mm :");
                this.rainTemp = int.Parse(Console.ReadLine());
                this.lsInMm.Add(rainTemp);
                this.rainTotal += rainTemp;
                counter++;
            }
            catch (Exception)
            {
            }
        } while (counter < 6);
	}

   

    public int GetSepAverage()
    {
        return sepAverage;
    }

    public int GetResultComparison()
    {
        return resultComparison;
    }

    private void CalcRainAverage()
    {
        this.rainAverage = this.rainTotal / this.lsInMm.Count;
    }

    public int GetRainAverage()
    {
        return rainAverage;
    }

    private int CompareRainAverageVsSepAverage()
    {
        int result = -2; //error code

        if (rainAverage < sepAverage)
        {
            result = - 1;
        }
        else if (rainAverage == sepAverage)
        {
            result = 0;
        }
        else if (rainAverage > sepAverage)
        {
            result = 1;
        }
        return result;
    }

}

/*
# SL_Prg_RainOver5Days
SmartLearning studiecafe: 13.september 2022 kl. 20:00

https://studie.smartlearning.dk/mod/page/view.php?id=606958

I aftenens studiecafé kan I arbejde med denne opgave - I er også velkomne til at bruge tiden på noget andet, som I synes giver mere mening.

September kan være en regnfuld måned, og der falder normalt 75 mm nedbør i september i gennemsnit.
https://vejr.tv2.dk/2020-10-01-ny-klimanormal-for-september-maaneden-er-blevet-naesten-en-grad-varmere

Lav et program, hvor man kan indtaste fem dages nedbør målt i mm.

Programmet skal derefter udskrive gennemsnittet af de fem tal og fortælle, om det gennemsnit er over eller under gennemsnittet for september.
Der er mange måde at løse opgaven på. Når I har løst den, må I af jer gerne dele den i forummet.
*/