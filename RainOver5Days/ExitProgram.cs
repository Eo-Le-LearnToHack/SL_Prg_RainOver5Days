using System;

public class ExitProgram
{
	public ExitProgram()
	{
        EscToExit();
    }

	private void EscToExit()
	{
        Console.WriteLine("\nTryk på en vilkårlig tast for at prøve igen ellers tryk på Esc for at lukke ned.");

        ConsoleKeyInfo csi = new();
        csi = Console.ReadKey(true);
        if (csi.Key == ConsoleKey.Escape)
        {
            Console.WriteLine("\nProgrammet lukker ned.");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
