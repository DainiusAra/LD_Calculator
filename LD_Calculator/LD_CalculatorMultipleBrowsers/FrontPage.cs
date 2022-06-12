
using System.Globalization;

namespace LD_Calculator.LD_CalculatorMultipleBrowsers
{
    public class FrontPage : BasePage
    {
        public FrontPage(IWebDriver webDriver) : base(webDriver) { }

        private IWebElement InputNum1FieldElement => webDriver.FindElement(By.Id("num1"));
        private IWebElement InputNum2FieldElement => webDriver.FindElement(By.Id("num2"));
        private IWebElement InputNum2FieldIntElement => webDriver.FindElement(By.Id("num2"));
        private IWebElement ClickAddElement => webDriver.FindElement(By.Id("add"));
        private IWebElement ClickSubtractElement => webDriver.FindElement(By.Id("subtract"));
        private IWebElement ClickMultiplyElement => webDriver.FindElement(By.Id("multiply"));
        private IWebElement ClickDivideElement => webDriver.FindElement(By.Id("divide"));

        private IWebElement CheckResultElement => webDriver.FindElement(By.Id("result"));

        public FrontPage InputNum1Field(string number1)
        {
            InputNum1FieldElement.SendKeys(number1);
            return new FrontPage(webDriver);
        }
        public FrontPage InputNum2Field(string number2)
        {
            InputNum2FieldElement.SendKeys(number2);
            return new FrontPage(webDriver);
        }
        public FrontPage ClickAdd()
        {
            ClickAddElement.Click();
            return new FrontPage(webDriver);
        }
        public FrontPage ClickSubstract()
        {
            ClickSubtractElement.Click();
            return new FrontPage(webDriver);
        }
        public FrontPage ClickMultiply()
        {
            ClickMultiplyElement.Click();
            return new FrontPage(webDriver);
        }
        public FrontPage ClickDivide()
        {
            ClickDivideElement.Click();
            return new FrontPage(webDriver);
        }
        public FrontPage AssertTotal(string total)
        {
            //Math.Round(Convert.ToDecimal(total), 2);
            Assert.AreEqual(total, CheckResultElement.Text);
            return this;
        }
    }
}
