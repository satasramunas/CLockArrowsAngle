using ClockArrowsAngle.Services;

var appService = new CalculationService();

Console.WriteLine("---------------------------------------");
Console.WriteLine("Ths is a clock arrows angle calculator |");
Console.WriteLine("---------------------------------------\n");

while (true)
{
    try
    {
        Console.WriteLine("Enter the hours (from 1 to 24):");
        int hours = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the minutes (from 1 to 59):");
        int minutes = int.Parse(Console.ReadLine());

        appService.CalculateAngle(hours, minutes);
    }
    catch (Exception)
    {
        Console.WriteLine("An error occured. Press \"Enter\" and try again with a valid number.");
    }

    Console.ReadLine();
}
