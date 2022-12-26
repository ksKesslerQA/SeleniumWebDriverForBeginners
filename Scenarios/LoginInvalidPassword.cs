
using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumWebDriverForBeginners.Scenarios
{
    [Parallelizable] //[Parallelizable(ParallelScope.None)]
    public class LoginInvalidPassword
    {
        IAlert alert;
        public IWebDriver Driver { get; set; }

        public LoginInvalidPassword()
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
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Invalid.Password.FourCharacters, Config.Credentials.Valid.RepeatPassword, Driver);

            alert = Driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.InvalidPassword, alert.Text);
            alert.Accept();
        }

        [Test]
        public void MoreThan12Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Invalid.Password.ThirteenCharacters, Config.Credentials.Valid.RepeatPassword, Driver);

            alert = Driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.InvalidPassword, alert.Text);
            alert.Accept();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}