using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Fact]
        public void Test1()
        {
            Xunit.Assert.True(true);
        }

        [Fact]
        public void TestMyFunctionZeros()
        {
            var res = Program.MyFunction(0.0, 0.0, 0.0);
            Xunit.Assert.Equal(double.NaN, res);
        }

        [Fact]
        public void TestTaskBNullMass()
        {
            var mass = new double[0];
            var res = Program.TaskB(2, 2, mass);
            Xunit.Assert.Equal(mass, res);
        }

        [Fact]
        public void TestTaskB()
        {
            var x = new double[] { 4.48, 3.56, 2.78, 5.28, 3.21 };
            var res = Program.TaskB(0.4, 0.8, x);
            var expy = new double[] { 0.798679667502177, 0.939641931397199, 1.04398881001066, 0.681446026430611, 0.9901277581819 };
            for (int i = 0; i < 5; i++)
            {
                Xunit.Assert.Equal(expy[i], res[i], 3);
            }
        }
    }
}