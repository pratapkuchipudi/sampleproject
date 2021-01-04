using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using FluentAssertions;
using System;


namespace netcore.template.Pages
{
    class CommonOBJs
    {
        IWebDriver _driver;
        private static WebDriverWait wait;

        public CommonOBJs(IWebDriver driver)
        {
            _driver = driver;
        }

        private static IWebElement FindByText(IWebDriver driver, string text)
        {
            IWebElement obj_pageObject = driver.FindElement(By.XPath("//*[contains(text(),'" + text + "')]"));
            return obj_pageObject;
        }
        private static IWebElement Continuebtn(IWebDriver driver)
        {
            IWebElement btn_Continue = driver.FindElement(By.XPath("//button[contains(text(), 'Continue')]"));
            return btn_Continue;
        }

    }
}
