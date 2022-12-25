using SeleniumWebDriverForBeginners.UIElements;

namespace SeleniumWebDriverForBeginners
{
    public static class Navigate
    {
        public static void LoginFormThroughTheMenu()
        {
            Menu menu = new Menu();
            TestScenariosPage tsPage = new TestScenariosPage();

            menu.TestScenarios.Click();
            tsPage.LoginForm.Click();
        }

        public static void LoginFormThroughThePost()
        {
            Menu menu = new Menu();
            TestCasesPage tcPage = new TestCasesPage();
            UsernameFieldPost ufPost = new UsernameFieldPost();

            menu.TestCases.Click();
            tcPage.UsernameFieldInLoginForm.Click();
            ufPost.LoginFormLink.Click();

        }
    }
}
