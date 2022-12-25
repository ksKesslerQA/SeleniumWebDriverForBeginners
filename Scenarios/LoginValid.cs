using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumWebDriverForBeginners.Scenarios
{
    public class LoginValid
    {
        IAlert alert;

        public LoginValid()
        {
        }

        [SetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            Navigate.LoginFormThroughTheMenu();

        }

        [Test]
        public void ValidLogin()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);

            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.SuccessfulLogin, alert.Text);
            alert.Accept();
        }



        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
