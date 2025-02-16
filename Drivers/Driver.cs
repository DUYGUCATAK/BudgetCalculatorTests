using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BudgetCalculatorTests.Drivers
{
    public class Driver
    {
        public IWebDriver WebDriver { get; private set; }

        public Driver()
        {
            WebDriver = new ChromeDriver();
        }

        public void Close()
        {
            WebDriver.Quit();
        }
    }
}
