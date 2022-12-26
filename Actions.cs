using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWebDriverForBeginners.UIElements;
using System;
using System.Threading;

namespace SeleniumWebDriverForBeginners
{
    public static class Actions
    {
        public static IWebDriver InitializeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Config.BaseURL);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            return driver;
        }
        public static void FillLoginForm(string username, string password, string repeatPassword, IWebDriver driver)
        {
            LoginScenarioPost lsPost = new LoginScenarioPost(driver);

            Thread.Sleep(500);
            lsPost.UsernameField.Clear();
            lsPost.UsernameField.SendKeys(username);
            Thread.Sleep(500);
            lsPost.PasswordField.Clear();
            lsPost.PasswordField.SendKeys(password);
            Thread.Sleep(500);
            lsPost.RepeatPasswordField.Clear();
            lsPost.RepeatPasswordField.SendKeys(repeatPassword);
            Thread.Sleep(500);
            lsPost.LoginButton.Click();

        }
    }
}
