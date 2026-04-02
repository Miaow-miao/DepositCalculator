using Microsoft.VisualStudio.TestTools.UnitTesting;
using DepositCalculator;

namespace DepositCalculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Simple_ShouldCalculateCorrectly()
        {

            double P = 10000;
            double rate = 0.12;
            int months = 12;
            double result = Calculator.Simple(P, rate, months);


            Assert.AreEqual(11200, result, 0.01);
        }

        [TestMethod]
        public void Simple_ZeroRate_ShouldReturnInitialAmount()
        {
            double result = Calculator.Simple(10000, 0, 12);

            Assert.AreEqual(10000, result, 0.01);
        }

        [TestMethod]
        public void Compound_ShouldCalculateCorrectly()
        {
            double P = 10000;
            double rate = 0.12;
            int months = 12;

            double result = Calculator.Compound(P, rate, months);

            Assert.IsTrue(result > 10000);
        }

        [TestMethod]
        public void Compound_ZeroRate_ShouldReturnInitialAmount()
        {
            double result = Calculator.Compound(10000, 0, 12);

            Assert.AreEqual(10000, result, 0.01);
        }

        [TestMethod]
        public void Compound_ShouldGrowMoreThanSimple()
        {
            double simple = Calculator.Simple(10000, 0.12, 12);
            double compound = Calculator.Compound(10000, 0.12, 12);

            Assert.IsTrue(compound > simple);
        }
    
        [TestMethod]
        public void NegativeAmount_ShouldWork()
        {
            double result = Calculator.Simple(-1000, 0.1, 12);
            Assert.IsTrue(result < 0);
        }
        [TestMethod]
        public void ZeroMonths_ShouldReturnInitialAmount()
        {
            double result = Calculator.Simple(10000, 0.1, 0);
            Assert.AreEqual(10000, result, 0.01);
        }
    }
        
}