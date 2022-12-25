namespace SeleniumWebDriverForBeginners
{
    public static class Config
    {
        public static string BaseURL = "https://testing.todorvachev.com/";

        public static class Credentials
        {
            public static class Valid
            {
                public static string Username = "ValidUsed";
                public static string Password = "asdf1234!";
                public static string RepeatPassword = "asdf1234!";
                public static string Email = "example@example.com";
            }
            public static class Invalid
            {
                public static class Username
                {
                    public static string FourCharacters = "Asdf";
                    public static string ThirteenCharacters = "AsdfAsdfAsdfa";
                }

                public static class Password
                {
                    public static string FourCharacters = "as1!";
                    public static string ThirteenCharacters = "as1!as1!as1!2";

                }

                public static class Email
                {

                }
            }
        }

        public static class AlertMessages
        {
            public static string SuccessfulLogin = "Succesful login!";
            public static string InvalidUsername = "User Id should not be empty / length be between 5 to 12";
            public static string InvalidPassword = "Password should not be empty / length be between 5 to 12";
            public static string InvalidRepeatedPassword = "Passwords do not match!";
        }
    }
}
