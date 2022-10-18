using ClockArrowsAngle.Services;
using NUnit.Framework;

namespace ClockArrowsAngle.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetHourArrowAngle_GivenInputs_Calculates()
        {
            var appService = new CalculationService();
            int hour = 11;
            int minute = 30;
            var angle = appService.GetHourArrowAngle(hour, minute);
            Assert.AreEqual(345, angle);
        }

        [Test]
        public void GetMinuteArrowAngle_GivenInput_Calculates()
        {
            var appService = new CalculationService();
            int minute = 30;
            var angle = appService.GetMinuteArrowAngle(minute);
            Assert.AreEqual(180, angle);
        }

        [Test]
        public void GetArrowsAngle_GivenInputs_Calculates()
        {
            var appService = new CalculationService();
            int hour = 11;
            int minute = 30;
            var angle = appService.CalculateAngle(hour, minute);
            Assert.AreEqual(165, angle);
        }
    }
}