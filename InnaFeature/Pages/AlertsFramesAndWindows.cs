using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnaFeature.Pages
{
    internal class AlertsFramesAndWindows : BasePage
    {
        public AlertsFramesAndWindows(IWebDriver driver) : base(driver)
        {

        }
        public IWebElement NewTabButton =>
            WebDriver.FindElement(By.XPath("//*[@id = 'tabButton']"));

    }

}
