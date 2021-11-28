namespace Lesson4.Tasks.Task4
{
    internal class AccountSerializer 
    {
        public static string AccountToString(Account account)
        {
            return $"{account.login}, {account.password}";
        }

        public static Account StringToAccount(string value)
        {
            string[] splittedText = value.Split(',');

            if (splittedText.Length == 2)
            {
                string login = splittedText[0].Trim();
                string password = splittedText[1].Trim();
                return new Account(login, password);
            }

            return new Account("null", "null");
        }
    }
}
