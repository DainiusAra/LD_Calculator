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
            [Test]
            public void NegativeEvenNumbersAdd()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-10").InputNum2Field("-20").ClickAdd().AssertTotal("-30");
            }
             // Test fails, because you can't input - (minus sign) into num2 textbox
            [Test]
            public void OddNumbersAdd()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("7").InputNum2Field("7").ClickAdd().AssertTotal("14");
            }
            
            [Test]
            public void NegativeOddNumbersAdd()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-7").InputNum2Field("-7").ClickAdd().AssertTotal("-14");
            }
             // Test fails, because you can't input - (minus sign) into num2 textbox
            [Test]
            public void EvenNumbersSubstract()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("20").InputNum2Field("10").ClickSubstract().AssertTotal("10");
            }
            
            [Test]
            public void NegativeEvenNumbersSubstract()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-20").InputNum2Field("-10").ClickSubstract().AssertTotal("-10");
            }
             // Test fails, because you can't input - (minus sign) into num2 textbox
            [Test]
            public void OddNumbersSubstract()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("14").InputNum2Field("7").ClickSubstract().AssertTotal("7");
            }
            
            [Test]
            public void NegativeOddNumbersSubstract()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-14").InputNum2Field("-7").ClickSubstract().AssertTotal("-7");
            }
             // Test fails, because you can't input - (minus sign) into num2 textbox
            [Test]
            public void EvenNumbersMultiply()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("6").InputNum2Field("6").ClickMultiply().AssertTotal("36");
            }
            
            [Test]
            public void NegativeEvenNumbersMultiply()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-6").InputNum2Field("-6").ClickMultiply().AssertTotal("36");
            }
             // Test fails, because you can't input - (minus sign) into num2 textbox
            [Test]
            public void OddNumbersMultiply()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("9").InputNum2Field("5").ClickMultiply().AssertTotal("45");
            }
            
            [Test]
            public void NegativeOddNumbersMultiply()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-9").InputNum2Field("-5").ClickMultiply().AssertTotal("45");
            }
             // Test fails, because you can't input - (minus sign) into num2 textbox
            [Test]
            public void EvenNumbersDivide()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("36").InputNum2Field("6").ClickDivide().AssertTotal("6");
            }
             [Test]
            public void NegativeEvenNumbersDivide()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-36").InputNum2Field("-6").ClickDivide().AssertTotal("6");
            }
             // Test fails, because you can't input - (minus sign) into num2 textbox
            [Test]
            public void OddNumbersDivide()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("45").InputNum2Field("9").ClickDivide().AssertTotal("5");
            }
             [Test]
            public void NegativeOddNumbersDivide()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-45").InputNum2Field("-9").ClickDivide().AssertTotal("5");
            }
            // Test fails, because you can't input - (minus sign) into num2 textbox
            [Test]
            public void DecimalNumbersAdd()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("2.35").InputNum2Field("5.89").ClickAdd().AssertTotal("8.24");
            }
            // Test fails, because you can't input decimal seprator into num2 textbox
            [Test]
            public void DecimalNumbersSubstract()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("11.80").InputNum2Field("2.50").ClickSubstract().AssertTotal("9.30");
            }
            // Test fails, because you can't input decimal seprator into num2 textbox
            [Test]
            public void DecimalNumbersMultiply()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("5.50").InputNum2Field("2.50").ClickMultiply().AssertTotal("13.75");
            }
            // Test fails, because you can't input decimal seprator into num2 textbox
            [Test]
            public void DecimalNumbersDivide()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("5.50").InputNum2Field("2.50").ClickDivide().AssertTotal("2.20");
            }
            // Test fails, because you can't input decimal seprator into num2 textbox
            [Test]
            public void Num1EvenNum2OddNumbersAdd()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("10").InputNum2Field("15").ClickAdd().AssertTotal("25");
            }
            [Test]
            public void Num1EvenNum2OddNumbersSubstract()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("25").InputNum2Field("10").ClickSubstract().AssertTotal("15");
            }
            [Test]
            public void Num1EvenNum2OddNumbersMultiply()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("2").InputNum2Field("5").ClickMultiply().AssertTotal("10");
            }
            [Test]
            public void Num1EvenNum2OddNumbersDivide()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("10").InputNum2Field("5").ClickDivide().AssertTotal("2");
            }
            [Test]
            public void Num1OddNum2EvenNumbersAdd()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("15").InputNum2Field("20").ClickAdd().AssertTotal("35");
            }
            [Test]
            public void Num1OddNum2EvenNumbersSubstarct()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("25").InputNum2Field("20").ClickSubstract().AssertTotal("5");
            }
            [Test]
            public void Num1OddNum2EvenNumbersMultiply()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("5").InputNum2Field("2").ClickMultiply().AssertTotal("10");
            }
            [Test]
            public void Num1OddNum2EvenNumbersDivide()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("5").InputNum2Field("20").ClickDivide().AssertTotal("0.25");
            }
            [Test]
            public void NegativeNum1EvenNegativeNum2OddNumbersAdd()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-10").InputNum2Field("-15").ClickAdd().AssertTotal("-25");
            }
            // Test fails, because you can't input decimal seprator into num2 textbox
            [Test]
            public void NegativeNum1EvenNegativeNum2OddNumbersSubstract()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-25").InputNum2Field("-10").ClickSubstract().AssertTotal("-15");
            }
            // Test fails, because you can't input decimal seprator into num2 textbox
            [Test]
            public void NegativeNum1EvenNegativeNum2OddNumbersMultiply()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-2").InputNum2Field("-5").ClickMultiply().AssertTotal("10");
            }
            // Test fails, because you can't input decimal seprator into num2 textbox
            [Test]
            public void NegativeNum1EvenNegativeNum2OddNumbersDivide()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-10").InputNum2Field("-5").ClickDivide().AssertTotal("2");
            }
            // Test fails, because you can't input decimal seprator into num2 textbox
            [Test]
            public void NegativeNum1OddNegativeNum2EvenNumbersAdd()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-15").InputNum2Field("-20").ClickAdd().AssertTotal("-35");
            }
            // Test fails, because you can't input decimal seprator into num2 textbox
            [Test]
            public void NegativeNum1OddNegativeNum2EvenNumbersSubstract()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-25").InputNum2Field("-20").ClickSubstract().AssertTotal("-5");
            }
            // Test fails, because you can't input decimal seprator into num2 textbox
            [Test]
            public void NegativeNum1OddNegativeNum2EvenNumbersMultiply()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-5").InputNum2Field("-2").ClickMultiply().AssertTotal("10");
            }
            // Test fails, because you can't input decimal seprator into num2 textbox
            [Test]
            public void NegativeNum1OddNegativeNum2EvenNumbersDivide()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-5").InputNum2Field("-20").ClickDivide().AssertTotal("0.25");
            }
            // Test fails, because you can't input decimal seprator into num2 textbox
            [Test]
            public void NegativeNum1EvenNum2EvenNumbersAdd()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-10").InputNum2Field("30").ClickAdd().AssertTotal("20");
            }
            [Test]
            public void NegativeNum1OddNum2OddNumbersAdd()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-15").InputNum2Field("25").ClickAdd().AssertTotal("10");
            }
            [Test]
            public void NegativeNum1EvenNum2OddNumbersAdd()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-10").InputNum2Field("15").ClickAdd().AssertTotal("5");
            }
            [Test]
            public void NegativeNum1OddNum2EvenNumbersAdd()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-15").InputNum2Field("10").ClickAdd().AssertTotal("-5");
            }
            [Test]
            public void NegativeNum1EvenNum2EvenNumbersSubstract()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-10").InputNum2Field("30").ClickSubstract().AssertTotal("-40");
            }
            [Test]
            public void NegativeNum1OddNum2OddNumbersSubstract()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-15").InputNum2Field("25").ClickSubstract().AssertTotal("-40");
            }
            [Test]
            public void NegativeNum1EvenNum2OddNumbersSubstract()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-10").InputNum2Field("15").ClickSubstract().AssertTotal("-25");
            }
            [Test]
            public void NegativeNum1OddNum2EvenNumbersSubstract()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-15").InputNum2Field("10").ClickSubstract().AssertTotal("-25");
            }
            [Test]
            public void NegativeNum1EvenNum2EvenNumbersMultiply()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-10").InputNum2Field("30").ClickMultiply().AssertTotal("-300");
            }
            [Test]
            public void NegativeNum1OddNum2OddNumbersMultiply()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-15").InputNum2Field("25").ClickMultiply().AssertTotal("-375");
            }
            [Test]
            public void NegativeNum1EvenNum2OddNumbersMultiply()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-10").InputNum2Field("15").ClickMultiply().AssertTotal("-150");
            }
            [Test]
            public void NegativeNum1OddNum2EvenNumbersMultiply()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-15").InputNum2Field("10").ClickMultiply().AssertTotal("-150");
            }
            [Test]
            public void NegativeNum1EvenNum2EvenNumbersDivide()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-10").InputNum2Field("30").ClickDivide().AssertTotal("-0.3333333333333333");
            }
            [Test]
            public void NegativeNum1OddNum2OddNumbersDivide()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-15").InputNum2Field("25").ClickDivide().AssertTotal("-0.6");
            }
            [Test]
            public void NegativeNum1EvenNum2OddNumbersDivide()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-10").InputNum2Field("15").ClickDivide().AssertTotal("-0.6666666666666666");
            }
            [Test]
            public void NegativeNum1OddNum2EvenNumbersDivide()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("-15").InputNum2Field("10").ClickDivide().AssertTotal("-1.5");
            }
            [Test]
            public void AddZerosInFront()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("0015").InputNum2Field("0010").ClickAdd().AssertTotal("NaN");
                // This should fail because 00 should't be allowed in front of the numbers
            }
            public void AddLettersInNum1Field()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("A").InputNum2Field("2").ClickAdd().AssertTotal("NaN");
                // This should fail because it shouldn'e be allowed
            }
            [TearDown]
            public void TearDown()
            {
                driver.Quit();
            }
        }
    }
}