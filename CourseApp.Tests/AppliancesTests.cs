using System;
using Xunit;

namespace CourseApp.Tests
{
    public class AppliancesTests
    {
        [Fact]
        public void TestEmptyConstructorTvAppliances()
        {
            var item = new TvAppliance();
            Assert.Equal(" ", item.Nazvanie);
            Assert.Equal(" ", item.Marka);
            Assert.Equal(219, item.Voltage);
            Assert.Equal(0, item.Warranty);
        }

        [Fact]
        public void TvApplianceTest1()
        {
            Appliances televizor = new TvAppliance("TV", "Samsung", 5, 220);
            televizor.Broke();
            Assert.Equal(" ", "This Apppliance is broken((");
        }

        [Fact]
        public void TvApplianceTest2()
        {
            // string nazvanie, string marka, int voltage, int warranty, int number
            Appliances televizor = new TvAppliance("TV", "Samsung", 5, 220);
            televizor.ByNew(televizor);
            Assert.Equal("TV", televizor.Nazvanie);
            Assert.Equal(220, televizor.Voltage);
            Assert.Equal(5, televizor.Warranty);
            Assert.Equal("Samsung", televizor.Marka);
        }

        [Fact]
        public void TestEmptyConstructorСlockAppliance()
        {
            var item = new СlockAppliance();
            Assert.Equal(new DateTime(0, 0, 0), item.Time2);
            Assert.Equal(" ", item.Marka);
            Assert.Equal(1, item.Voltage);
            Assert.Equal(0, item.Warranty);
        }

        [Fact]
        public void СlockApplianceTest1()
        {
            // string nazvanie, string marka, int voltage, int warranty, DateTime time1
            Appliances clockAppliance = new СlockAppliance("clock", "samsung", 220, 2, new DateTime(0, 0, 0));
            clockAppliance.Broke();
            Assert.Equal(" ", "This Apppliance is broken((");
        }

        [Fact]
        public void СlockApplianceTest2()
        {
            Appliances clockAppliance = new СlockAppliance("clock", "samsung", 220, 2, new DateTime(0, 0, 0));
            clockAppliance.ByNew(clockAppliance);
            Assert.Equal("Samsung", clockAppliance.Marka);
            Assert.Equal(220, clockAppliance.Voltage);
            Assert.Equal(5, clockAppliance.Warranty);
        }

        [Fact]
        public void TestIncorrectSetTvVoltage()
        {
            try
            {
                var item = new TvAppliance();
                item.Voltage = -8;
            }
            catch (System.Exception)
            {
                Console.WriteLine("You Appliances willn't work");
                Assert.True(true);
            }
        }

        [Fact]
        public void TestIncorrectSetClockVoltage()
        {
            try
            {
                var item = new СlockAppliance();
                item.Voltage = -8;
            }
            catch (System.Exception)
            {
                Console.WriteLine("You Appliances willn't work");
                Assert.True(true);
            }
        }
    }
}