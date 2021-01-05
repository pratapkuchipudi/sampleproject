using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using OpenQA.Selenium;
using netcore.template.Pages;

namespace netcore.template 
{
   public class MainAppSteps 
   {
      public static IWebDriver _driver;

      [Step("Use Browser2 <browser>")]
      public void UseBrowserChrome(string browser) {
         Environment.SetEnvironmentVariable("BROWSER", browser);
      }

      [Step("Initialize webdriver")]
      public void InitializeDriver() {
         string browser = "";
         _driver = DriverFactory.GetDriver(browser);
         _driver.Manage().Window.Maximize();
         _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
      }

      [Step("Navigate into application <url>")]
      public void NavigateIntoApplication(String url) {
         _driver.Navigate().GoToUrl(url);
      }

      [Step("Click on Login BUtton")]
      public void ClickOnLoginButton() {
         Login_Decisions.ClickOnLoginButton(_driver);

      }

      [Step("Enter username <username>")]
      public void EnterAuth0Username(String username) {
         Login_Decisions.EnterEmail(_driver, username);
         //Environment.SetEnvironmentVariable("username", username);
      }

      [Step("Enter password <password>")]
      public void EnteAuth0Password(String password) {
         Login_Decisions.EnterPassword(_driver, password);
      }

      [Step("Click on Signin Button")]
      public void ClickOnSigninButton() {
         Login_Decisions.ClickLogin(_driver);
      }
   
   }
}