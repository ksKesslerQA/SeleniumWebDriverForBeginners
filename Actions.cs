using OpenQA.Selenium.Chrome;
using SeleniumWebDriverForBeginners.UIElements;
using System.Threading;

namespace SeleniumWebDriverForBeginners
{
    public static class Actions
    {
        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
        }
        public static void FillLoginForm(string username, string password, string repeatPassword)
        {
            LoginScenarioPost lsPost = new LoginScenarioPost();

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
