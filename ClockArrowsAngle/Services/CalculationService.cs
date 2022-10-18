namespace ClockArrowsAngle.Services
{
    public class CalculationService
    {
        // Calculates the angle between the hour arrow and 12:00 (in reference to 12:00)
        public int GetHourArrowAngle(int hours, int minutes)
        {
            if (hours > 12)
            {
                hours -= 12;
            }
            return (int)(0.5 * (hours * 60 + minutes));
        }

        // Calculates the angle between the minute arrow and 12:00 (in reference to 12:00)
        public int GetMinuteArrowAngle(int minutes)
        {
            return 6 * minutes;
        }

        // Calculates the angle (difference) between the hour and minute arrows
        public int CalculateAngle(int hours, int minutes)
        {
            if (hours < 0 || hours > 24)
            {
                Console.WriteLine("Please use a number from 1 to 24 for the hours. Press \"Enter\" to try again.");

                return 0;
            }
            else if (minutes < 0 || minutes > 59)
            {
                Console.WriteLine("Please use a number from 1 to 59 for the minutes. Press \"Enter\" to try again.");

                return 0;
            }
            else
            {
                int hourAngle = GetHourArrowAngle(hours, minutes);
                int minuteAngle = GetMinuteArrowAngle(minutes);

                int result = Math.Abs(hourAngle - minuteAngle);

                result = Math.Min(360 - result, result);

                Console.WriteLine("\nThe lesser angle between the hours arrow and minutes arrow: {0} degrees", result);
                Console.WriteLine("\nPress \"Enter\" to calculate again or just exit the application.");

                return result;
            }
        }
    }
}
