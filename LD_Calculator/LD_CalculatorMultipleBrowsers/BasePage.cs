using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LD_Calculator.LD_CalculatorMultipleBrowsers
{
    public class BasePage
    {
        public IWebDriver webDriver = null;

        public BasePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
    }
}
