using OpenQA.Selenium;
using SeleniumWebDriverForBeginners.UIElements;

namespace SeleniumWebDriverForBeginners
{
    public static class Navigate
    {
        public static void LoginFormThroughTheMenu(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            TestScenariosPage tsPage = new TestScenariosPage(driver);

            menu.TestScenarios.Click();
            tsPage.LoginForm.Click();
        }

        public static void LoginFormThroughThePost(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            TestCasesPage tcPage = new TestCasesPage(driver);
            UsernameFieldPost ufPost = new UsernameFieldPost(driver);

            menu.TestCases.Click();
            tcPage.UsernameFieldInLoginForm.Click();
            ufPost.LoginFormLink.Click();

        }
    }
}
