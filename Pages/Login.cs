using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace netcore.template.Pages
{
    class Login
    {
        IWebDriver _driver;
        private static WebDriverWait wait;

        public Login(IWebDriver driver)
        {
            _driver = driver;
        }

        private static IWebElement LoginUsername(IWebDriver driver)
        {
            IWebElement txt_LoginUsername = driver.FindElement(By.Name("username"));
            return txt_LoginUsername;
        }
        private static IWebElement BtnLogin(IWebDriver driver)
        {
            IWebElement btn_Login = driver.FindElement(By.ClassName("auth0-lock-submit"));
            return btn_Login;
        }
        private static IWebElement Password(IWebDriver driver)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement Dele = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name("password")));

            IWebElement txt_Password = driver.FindElement(By.Name("password"));
            return txt_Password;
        }
        private static IWebElement SignUp(IWebDriver driver)
        {
            IWebElement lnk_SignUp = driver.FindElement(By.CssSelector("a[href='/signUp?nosso=true']"));
            return lnk_SignUp;
        }
        private static IWebElement ResetPassword(IWebDriver driver)
        {
            IWebElement lnk_ResetPass = driver.FindElement(By.CssSelector("a[href='/requestPasswordReset?nosso=true']"));
            return lnk_ResetPass;
        }
        private static IWebElement Cancel(IWebDriver driver)
        {
            IWebElement lnk_Cancel = driver.FindElement(By.ClassName("auth0-lock-alternative-link"));
            return lnk_Cancel;
        }
        private static IWebElement Alert(IWebDriver driver)
        {
            IWebElement lbl_Alert = driver.FindElement(By.Id("message-alert"));
            return lbl_Alert;
        }
        private static IWebElement ToastTitle(IWebDriver driver)
        {
            IWebElement lbl_Toast_title = driver.FindElement(By.ClassName("toast-title"));
            return lbl_Toast_title;
        }
        private static IWebElement ToastMessage(IWebDriver driver)
        {
            IWebElement lbl_Toast_message = driver.FindElement(By.ClassName("toast-message"));
            return lbl_Toast_message;
        }
        private static IWebElement ToastButton(IWebDriver driver)
        {
            IWebElement lbl_Toast_Close = driver.FindElement(By.ClassName("toast-close-button"));
            return lbl_Toast_Close;
        }
        private static IWebElement AuthErrormsg(IWebDriver driver)
        {
            IWebElement lbl_auth0_errormsg = driver.FindElement(By.ClassName("auth0-lock-error-msg"));
            return lbl_auth0_errormsg;
        }

        public static void EnterEmail(IWebDriver driver, string username)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            IWebElement Dele = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name("username")));
            Thread.Sleep(1000);
            LoginUsername(driver).SendKeys(username);
            LoginUsername(driver).Submit();
        }

        public static void EnterPassword(IWebDriver driver, string username, string password)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            IWebElement pass = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name("password")));
            Password(driver).SendKeys(password);
        }

        public static void ClickLogin(IWebDriver driver)
        {
            BtnLogin(driver).Click();
        }
    }
}
