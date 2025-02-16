using NUnit.Framework;
using OpenQA.Selenium;
using BudgetCalculatorTests.Drivers;
using BudgetCalculatorTests.Pages;

namespace BudgetCalculatorTests.Tests
{
    public class BudgetCalculatorTests
    {
        private Driver _driver;
        private CalculatorPage _calculatorPage;

        [SetUp]
        public void Setup()
        {
            _driver = new Driver();
            _calculatorPage = new CalculatorPage(_driver.WebDriver);
        }

        [Test]
        public void TestCase_5_YatirimUcreti_200_Olmali()
        {
            _calculatorPage.OpenCalculator();
            _calculatorPage.EnterNumber("1000");
            _calculatorPage.ClickSubtract();
            _calculatorPage.EnterNumber("800");
            _calculatorPage.ClickEquals();

            Assert.AreEqual("200", _calculatorPage.GetResult());
        }

        [Test]
        public void TestCase_6_YatirimUcreti_0_Olmali()
        {
            _calculatorPage.OpenCalculator();
            _calculatorPage.EnterNumber("1000");
            _calculatorPage.ClickSubtract();
            _calculatorPage.EnterNumber("1000");
            _calculatorPage.ClickEquals();

            Assert.AreEqual("0", _calculatorPage.GetResult());
        }

        [Test]
        public void TestCase_7_YatirimUcreti_Minus200_Olmali()
        {
            _calculatorPage.OpenCalculator();
            _calculatorPage.EnterNumber("1000");
            _calculatorPage.ClickSubtract();
            _calculatorPage.EnterNumber("1200");
            _calculatorPage.ClickEquals();

            Assert.AreEqual("-200", _calculatorPage.GetResult());
        }

        [TearDown]
        public void Teardown()
        {
            _driver.Close();
        }
    }
}
