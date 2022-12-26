using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumWebDriverForBeginners.Scenarios
{
    [Parallelizable]
    public class LoginInvalidUsername
    {
        IAlert alert;
        public IWebDriver Driver { get; set; }
        public LoginInvalidUsername()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Driver = Actions.InitializeDriver();
            Navigate.LoginFormThroughTheMenu(Driver);

        }

        [Test]
        public void LessThan5Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.FourCharacters, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword, Driver);

            alert = Driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.InvalidUsername, alert.Text);
            alert.Accept();
        }

        [Test]
        public void MoreThan12Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.ThirteenCharacters, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword, Driver);

            alert = Driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.InvalidUsername, alert.Text);
            alert.Accept();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}