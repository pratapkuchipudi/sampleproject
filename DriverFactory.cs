using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace netcore.template
{
    public class DriverFactory
    {
        public static IWebDriver GetDriver(string browser)
        {
            browser = Environment.GetEnvironmentVariable("BROWSER");

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = ("C:\\Automation\\Automation\\firefox.exe");
            EdgeOptions Eoptions = new EdgeOptions();
            switch (browser)
            {
                case "chrome":
                case "Chrome":
                    return new ChromeDriver();
                case "ie":
                case "IE":
                    return new InternetExplorerDriver();
                case "edge":
                case "Edge":
                    return new EdgeDriver("C:\\Windows\\System32\\", Eoptions);
                default:
                    return new FirefoxDriver(options);
            }
        }
    }
}
