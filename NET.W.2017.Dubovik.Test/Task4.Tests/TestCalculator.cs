using System;
using System.Collections.Generic;
using NUnit.Framework;
using Task4.Solution;

namespace Task4.Tests
{
    [TestFixture]
    public class TestCalculator
    {
        private readonly List<double> values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

        [Test]
        public void Test_AverageByMean()
        {
            var calculatorInter = new CalculatorWithInter();
            var computing = new ComputingDoubleMean();
            double expected = 8.3636363;

            double actual = calculatorInter.CalculateAverage(values, computing);

            Assert.AreEqual(expected, actual, 0.000001);

            var calculatorDele = new CalculatorWithDele();

            actual = calculatorDele.CalculateAverage(values, computing.Computing);

            Assert.AreEqual(expected, actual, 0.000001);

        }

        [Test]
        public void Test_AverageByMedian()
        {
            var calculatorInter = new CalculatorWithInter();
            var computing = new ComputingDoubleMedian();
            double expected = 8.0;

            double actual = calculatorInter.CalculateAverage(values, computing);

            Assert.AreEqual(expected, actual, 0.000001);

            var calculatorDele = new CalculatorWithDele();

            actual = calculatorDele.CalculateAverage(values, computing.Computing);

            Assert.AreEqual(expected, actual, 0.000001);
        }
    }
}