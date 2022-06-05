using NUnit.Framework.Internal;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using LD_Calculator.LD_CalculatorMultipleBrowsers;

namespace LD.Calculator.LD_CalculatorMultipleBrowsers
{
    public class Calculator_Tests
    {
        // [TestFixture(typeof(FirefoxDriver))]    // num1 field has no style on firefox
        [TestFixture(typeof(ChromeDriver))]
        public class MultipleBrowser<TWebDriver> where
    TWebDriver : IWebDriver, new()
        {
            private IWebDriver driver;

            [SetUp]
            public void Setup()
            {
                driver = new TWebDriver();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                driver.Manage().Window.Maximize();
                driver.Url = "file:///C:/LD_Calculator/LD_Calculator/Calculator.html";
            }

            [Test]
            public void EvenNumbersAdd()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("10").InputNum2Field("20").ClickAdd().AssertTotal("30");
            }
            /*
            [Test]
            public void NegativeEvenNumbersAdd()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-10").InputNum2Field("-20").ClickAdd().AssertTotal("-30");
            }
            */ // You can't input - (minus sign) into num2 textbox
            [Test]
            public void OddNumbersAdd()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("7").InputNum2Field("7").ClickAdd().AssertTotal("14");
            }
            /*
            [Test]
            public void NegativeOddNumbersAdd()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-7").InputNum2Field("-7").ClickAdd().AssertTotal("-14");
            }
            */ // You can't input - (minus sign) into num2 textbox
            [Test]
            public void EvenNumbersSubstract()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("20").InputNum2Field("10").ClickSubstract().AssertTotal("10");
            }
            /*
            [Test]
            public void NegativeEvenNumbersSubstract()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-20").InputNum2Field("-10").ClickSubstract().AssertTotal("-10");
            }
            */ // You can't input - (minus sign) into num2 textbox
            [Test]
            public void OddNumbersSubstract()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("14").InputNum2Field("7").ClickSubstract().AssertTotal("7");
            }
            /*
            [Test]
            public void NegativeOddNumbersSubstract()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-14").InputNum2Field("-7").ClickSubstract().AssertTotal("-7");
            }
            */ // You can't input - (minus sign) into num2 textbox
            [Test]
            public void EvenNumbersMultiply()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("6").InputNum2Field("6").ClickMultiply().AssertTotal("36");
            }
            /*
            [Test]
            public void NegativeEvenNumbersMultiply()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-6").InputNum2Field("-6").ClickMultiply().AssertTotal("-36");
            }
            */ // You can't input - (minus sign) into num2 textbox
            [Test]
            public void OddNumbersMultiply()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("9").InputNum2Field("5").ClickMultiply().AssertTotal("45");
            }
            /*
            [Test]
            public void NegativeOddNumbersMultiply()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-9").InputNum2Field("-5").ClickMultiply().AssertTotal("-45");
            }
            */ // You can't input - (minus sign) into num2 textbox
            [Test]
            public void EvenNumbersDivide()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("36").InputNum2Field("6").ClickDivide().AssertTotal("6");
            }
            [Test]
            public void OddNumbersDivide()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("45").InputNum2Field("9").ClickDivide().AssertTotal("5");
            }
            [TearDown]
            public void TearDown()
            {
                driver.Quit();
            }
        }
    }
}