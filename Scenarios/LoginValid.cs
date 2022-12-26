using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumWebDriverForBeginners.Scenarios
{
    [Parallelizable]
    public class LoginValid
    {
        IAlert alert;
        public IWebDriver Driver { get; set; }

        public LoginValid()
        {
        }

        [SetUp]
        public void Initialize()
        {
            Driver = Actions.InitializeDriver();
            Navigate.LoginFormThroughTheMenu(Driver);

        }

        [Test]
        public void ValidLogin()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword, Driver);

            alert = Driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.SuccessfulLogin, alert.Text);
            alert.Accept();
        }



        [TearDown]
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}
