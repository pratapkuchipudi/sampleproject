using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using System.Data;
using System.IO;

namespace netcore.template.Pages
{
    class Login_Decisions
    {
           IWebDriver _driver;
                 
      private static WebDriverWait wait;
       IJavaScriptExecutor js; 
        public Login_Decisions(IWebDriver driver)
        {
            _driver = driver;
                      
        }
        private static IWebElement LoginUsername(IWebDriver driver)
        {
            IWebElement txt_LoginUsername = driver.FindElement(By.Id("userNameInput"));
            return txt_LoginUsername;
        }
        private static IWebElement BtnLogin(IWebDriver driver)
        {
            IWebElement btn_Login = driver.FindElement(By.Id("submitButton"));
            return btn_Login;
        }
        private static IWebElement Password(IWebDriver driver)
        {
            //wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //IWebElement Dele = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name("password")));

            IWebElement txt_Password = driver.FindElement(By.Id("passwordInput"));
            return txt_Password;
        }

        public static void ClickOnLoginButton(IWebDriver driver)
        {
            Auth0LoginBtn(driver).Click();
        }

        private static IWebElement Auth0LoginBtn(IWebDriver driver)
        {
            IWebElement login_btn = driver.FindElement(By.XPath("//button[@data-provider='windows']"));
            return login_btn;
        }


        public static void SelectAdminPortalApp(IWebDriver driver)
        {
            System.Threading.Thread.Sleep(3000);
            IWebElement globalNav_adminportal = driver.FindElement(By.XPath("//span[contains(text(),'Admin Portal')]"));
            globalNav_adminportal.Click();
             try
            {
                System.Threading.Thread.Sleep(3000);
                driver.FindElement(By.XPath("//button[@data-provider='windows']")).Click();
                
            }
            catch {}
            System.Threading.Thread.Sleep(3000);
           
        }

         private static IWebElement ClickProvDBButton(IWebDriver driver)
        {
            IWebElement nav_provDB = driver.FindElement(By.XPath("//span[contains(text(),'Provider DB')]"));
            return nav_provDB;
        }


        

        public static void EnterEmail(IWebDriver driver, string username)
        {
            
     
            System.Threading.Thread.Sleep(3000);
            LoginUsername(driver).SendKeys("username");
            //LoginUsername(driver).Submit();
        }

        public static void EnterPassword(IWebDriver driver, string password)
        {
            System.Threading.Thread.Sleep(3000);
            Password(driver).SendKeys("password");
        }

        public static void ClickLogin(IWebDriver driver)
        {
            BtnLogin(driver).Click();
        }

    }
}
