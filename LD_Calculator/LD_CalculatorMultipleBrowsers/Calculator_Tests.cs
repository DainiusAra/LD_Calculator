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
                newFrontPage.InputNum1FieldDouble(10).InputNum2FieldDouble(20).ClickAdd().AssertTotalDouble(30);
            }
            [Test]
            public void NegativeEvenNumbersAdd()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(-10).InputNum2FieldDouble(-20).ClickAdd().AssertTotalDouble(-30);
            }
             // Test fails, because you can't input - (minus sign) into num2 textbox
            [Test]
            public void OddNumbersAdd()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(7).InputNum2FieldDouble(7).ClickAdd().AssertTotalDouble(14);
            }
            
            [Test]
            public void NegativeOddNumbersAdd()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(-7).InputNum2FieldDouble(-7).ClickAdd().AssertTotalDouble(-14);
            }
             // Test fails, because you can't input - (minus sign) into num2 textbox
            [Test]
            public void EvenNumbersSubstract()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(20).InputNum2FieldDouble(10).ClickSubstract().AssertTotalDouble(10);
            }
            
            [Test]
            public void NegativeEvenNumbersSubstract()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(-20).InputNum2FieldDouble(-10).ClickSubstract().AssertTotalDouble(-10);
            }
             // Test fails, because you can't input - (minus sign) into num2 textbox
            [Test]
            public void OddNumbersSubstract()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(14).InputNum2FieldDouble(7).ClickSubstract().AssertTotalDouble(7);
            }
            
            [Test]
            public void NegativeOddNumbersSubstract()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(-14).InputNum2FieldDouble(-7).ClickSubstract().AssertTotalDouble(-7);
            }
             // Test fails, because you can't input - (minus sign) into num2 textbox
            [Test]
            public void EvenNumbersMultiply()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(6).InputNum2FieldDouble(6).ClickMultiply().AssertTotalDouble(36);
            }
            
            [Test]
            public void NegativeEvenNumbersMultiply()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(-6).InputNum2FieldDouble(-6).ClickMultiply().AssertTotalDouble(36);
            }
             // Test fails, because you can't input - (minus sign) into num2 textbox
            [Test]
            public void OddNumbersMultiply()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(9).InputNum2FieldDouble(5).ClickMultiply().AssertTotalDouble(45);
            }
            
            [Test]
            public void NegativeOddNumbersMultiply()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(-9).InputNum2FieldDouble(-5).ClickMultiply().AssertTotalDouble(45);
            }
             // Test fails, because you can't input - (minus sign) into num2 textbox
            [Test]
            public void EvenNumbersDivide()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(36).InputNum2FieldDouble(6).ClickDivide().AssertTotalDouble(6);
            }
             [Test]
            public void NegativeEvenNumbersDivide()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(-36).InputNum2FieldDouble(-6).ClickDivide().AssertTotalDouble(6);
            }
             // Test fails, because you can't input - (minus sign) into num2 textbox
            [Test]
            public void OddNumbersDivide()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(45).InputNum2FieldDouble(9).ClickDivide().AssertTotalDouble(5);
            }
             [Test]
            public void NegativeOddNumbersDivide()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(-45).InputNum2FieldDouble(-9).ClickDivide().AssertTotalDouble(5);
            }
            // Test fails, because you can't input - (minus sign) into num2 textbox
            [Test]
            public void DecimalNumbersAdd()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(2.35).InputNum2FieldDouble(5.89).ClickAdd().AssertTotalDouble(8.24);
            }
            // Test fails, because you can't input decimal seprator into num2 textbox
            [Test]
            public void DecimalNumbersSubstract()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(11.80).InputNum2FieldDouble(2.50).ClickSubstract().AssertTotalDouble(9.30);
            }
            // Test fails, because you can't input decimal seprator into num2 textbox
            [Test]
            public void DecimalNumbersMultiply()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(5.50).InputNum2FieldDouble(2.50).ClickMultiply().AssertTotalDouble(13.75);
            }
            // Test fails, because you can't input decimal seprator into num2 textbox
            [Test]
            public void DecimalNumbersDivide()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(5.50).InputNum2FieldDouble(2.50).ClickDivide().AssertTotalDouble(2.20);
            }
            // Test fails, because you can't input decimal seprator into num2 textbox
            [Test]
            public void Num1EvenNum2OddNumbersAdd()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(10).InputNum2FieldDouble(15).ClickAdd().AssertTotalDouble(25);
            }
            [Test]
            public void Num1EvenNum2OddNumbersSubstract()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(25).InputNum2FieldDouble(10).ClickSubstract().AssertTotalDouble(15);
            }
            [Test]
            public void Num1EvenNum2OddNumbersMultiply()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(2).InputNum2FieldDouble(5).ClickMultiply().AssertTotalDouble(10);
            }
            [Test]
            public void Num1EvenNum2OddNumbersDivide()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(10).InputNum2FieldDouble(5).ClickDivide().AssertTotalDouble(2);
            }
            [Test]
            public void Num1OddNum2EvenNumbersAdd()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(15).InputNum2FieldDouble(20).ClickAdd().AssertTotalDouble(35);
            }
            [Test]
            public void Num1OddNum2EvenNumbersSubstarct()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(25).InputNum2FieldDouble(20).ClickSubstract().AssertTotalDouble(5);
            }
            [Test]
            public void Num1OddNum2EvenNumbersMultiply()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(5).InputNum2FieldDouble(2).ClickMultiply().AssertTotalDouble(10);
            }
            [Test]
            public void Num1OddNum2EvenNumbersDivide()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(5).InputNum2FieldDouble(20).ClickDivide().AssertTotalDouble(0.25);
            }
            [Test]
            public void NegativeNum1EvenNegativeNum2OddNumbersAdd()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(-10).InputNum2FieldDouble(-15).ClickAdd().AssertTotalDouble(-25);
            }
            // Test fails, because you can't input decimal seprator into num2 textbox
            [Test]
            public void NegativeNum1EvenNegativeNum2OddNumbersSubstract()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(-25).InputNum2FieldDouble(-10).ClickSubstract().AssertTotalDouble(-15);
            }
            // Test fails, because you can't input decimal seprator into num2 textbox
            [Test]
            public void NegativeNum1EvenNegativeNum2OddNumbersMultiply()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(-2).InputNum2FieldDouble(-5).ClickMultiply().AssertTotalDouble(10);
            }
            // Test fails, because you can't input decimal seprator into num2 textbox
            [Test]
            public void NegativeNum1EvenNegativeNum2OddNumbersDivide()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(-10).InputNum2FieldDouble(-5).ClickDivide().AssertTotalDouble(2);
            }
            // Test fails, because you can't input decimal seprator into num2 textbox
            [Test]
            public void NegativeNum1OddNegativeNum2EvenNumbersAdd()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(-15).InputNum2FieldDouble(-20).ClickAdd().AssertTotalDouble(-35);
            }
            // Test fails, because you can't input decimal seprator into num2 textbox
            [Test]
            public void NegativeNum1OddNegativeNum2EvenNumbersSubstract()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(-25).InputNum2FieldDouble(-20).ClickSubstract().AssertTotalDouble(-5);
            }
            // Test fails, because you can't input decimal seprator into num2 textbox
            [Test]
            public void NegativeNum1OddNegativeNum2EvenNumbersMultiply()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(-5).InputNum2FieldDouble(-2).ClickMultiply().AssertTotalDouble(10);
            }
            // Test fails, because you can't input decimal seprator into num2 textbox
            [Test]
            public void NegativeNum1OddNegativeNum2EvenNumbersDivide()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(-5).InputNum2FieldDouble(-20).ClickDivide().AssertTotalDouble(0.25);
            }
            // Test fails, because you can't input decimal seprator into num2 textbox
            [Test]
            public void NegativeNum1EvenNum2EvenNumbersAdd()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(-10).InputNum2FieldDouble(30).ClickAdd().AssertTotalDouble(20);
            }
            [Test]
            public void NegativeNum1OddNum2OddNumbersAdd()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(-15).InputNum2FieldDouble(25).ClickAdd().AssertTotalDouble(10);
            }
            [Test]
            public void NegativeNum1EvenNum2OddNumbersAdd()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(-10).InputNum2FieldDouble(15).ClickAdd().AssertTotalDouble(5);
            }
            [Test]
            public void NegativeNum1OddNum2EvenNumbersAdd()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(-15).InputNum2FieldDouble(10).ClickAdd().AssertTotalDouble(-5);
            }
            [Test]
            public void NegativeNum1EvenNum2EvenNumbersSubstract()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(-10).InputNum2FieldDouble(30).ClickSubstract().AssertTotalDouble(-40);
            }
            [Test]
            public void NegativeNum1OddNum2OddNumbersSubstract()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(-15).InputNum2FieldDouble(25).ClickSubstract().AssertTotalDouble(-40);
            }
            [Test]
            public void NegativeNum1EvenNum2OddNumbersSubstract()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(-10).InputNum2FieldDouble(15).ClickSubstract().AssertTotalDouble(-25);
            }
            [Test]
            public void NegativeNum1OddNum2EvenNumbersSubstract()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(-15).InputNum2FieldDouble(10).ClickSubstract().AssertTotalDouble(-25);
            }
            [Test]
            public void NegativeNum1EvenNum2EvenNumbersMultiply()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(-10).InputNum2FieldDouble(30).ClickMultiply().AssertTotalDouble(-300);
            }
            [Test]
            public void NegativeNum1OddNum2OddNumbersMultiply()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(-15).InputNum2FieldDouble(25).ClickMultiply().AssertTotalDouble(-375);
            }
            [Test]
            public void NegativeNum1EvenNum2OddNumbersMultiply()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(-10).InputNum2FieldDouble(15).ClickMultiply().AssertTotalDouble(-150);
            }
            [Test]
            public void NegativeNum1OddNum2EvenNumbersMultiply()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(-15).InputNum2FieldDouble(10).ClickMultiply().AssertTotalDouble(-150);
            }
            [Test]
            public void NegativeNum1EvenNum2EvenNumbersDivide()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(-10).InputNum2FieldDouble(30).ClickDivide().AssertTotalDouble(-0.3333333333333333);
            }
            [Test]
            public void NegativeNum1OddNum2OddNumbersDivide()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(-15).InputNum2FieldDouble(25).ClickDivide().AssertTotalDouble(-0.6);
            }
            [Test]
            public void NegativeNum1EvenNum2OddNumbersDivide()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(-10).InputNum2FieldDouble(15).ClickDivide().AssertTotalDouble(-0.67);
            }
            [Test]
            public void NegativeNum1OddNum2EvenNumbersDivide()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(-15).InputNum2FieldDouble(10).ClickDivide().AssertTotalDouble(-1.5);
            }
            [Test]
            public void AddZerosInFront()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(0015).InputNum2FieldDouble(0010).ClickAdd().AssertTotal("NaN");
                // This should fail because 00 should't be allowed in front of the numbers
            }
            [Test]
            public void AddLettersInNum1Field()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1Field("A").InputNum2FieldDouble(2).ClickAdd().AssertTotal("NaN");
                // This should fail because it shouldn'e be allowed
            }

            [Test]
            public void TestTestTest()
            {
                FrontPage newFrontPage = new FrontPage(driver);
                newFrontPage.InputNum1FieldDouble(10).InputNum2FieldDouble(68).ClickDivide().AssertTotalDouble(0.15);
            }
            [TearDown]
            public void TearDown()
            {
               driver.Quit();
            }
        }
    }
}