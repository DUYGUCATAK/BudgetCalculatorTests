using OpenQA.Selenium;

namespace BudgetCalculatorTests.Pages
{
    public class CalculatorPage
    {
        private readonly IWebDriver _driver;
        
        public CalculatorPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void OpenCalculator()
        {
            _driver.Navigate().GoToUrl("https://catchylabs-webclient.testinium.com/");
            _driver.FindElement(By.XPath("//button[text()='OPEN CALCULATOR']")).Click();
        }

        public void EnterNumber(string number)
        {
            foreach (char digit in number)
            {
                _driver.FindElement(By.XPath($"//button[text()='{digit}']")).Click();
            }
        }

        public void ClickSubtract() => _driver.FindElement(By.XPath("//button[text()='-']")).Click();
        
        public void ClickEquals() => _driver.FindElement(By.XPath("//button[text()='=']")).Click();

        public string GetResult()
        {
            return _driver.FindElement(By.Id("result")).Text;
        }
    }
}
