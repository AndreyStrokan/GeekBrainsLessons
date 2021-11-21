using Lesson4.Common;
using System.IO;

namespace Lesson4.Tasks.Task4
{
    internal static class AccountFileDB
    {
        private const string DBName = "Accounts";

        public static bool CreateAccount(string login, string password)
        {
            Account newAccount = new Account(login, password);

            if (AccountExists(newAccount) == true)
            {
                return false;
            }

            using (StreamWriter streamWriter = new StreamWriter(DBName, true))
            {
                streamWriter.WriteLine(AccountSerializer.AccountToString(newAccount));
            }
            return true;
        }


        public static bool DBExists()
        {
            return File.Exists(DBName);
        }

        public static Account[] GetAllAccounts()
        {
            Account[] result = new Account[0];

            using (StreamReader streamWriter = new StreamReader(DBName))
            {
                string currentValue;
                while ((currentValue = streamWriter.ReadLine()) != null)
                {
                    ArrayUtils.AddValueToArray<Account>(ref result, AccountSerializer.StringToAccount(currentValue));
                }
            }

            return result;
        }

        public static bool TryAuthorize(string login, string password)
        {
            Account currentAccount = new Account(login, password);

            Account[] allAccounts = GetAllAccounts();

            for (int i = 0; i < allAccounts.Length; i++)
            {
                if (currentAccount.Equals(allAccounts[i]) == true)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool AccountExists(Account account)
        {
            if (DBExists() == false)
            {
                return false;
            }

            Account[] allAccounts = GetAllAccounts();

            for (int i = 0; i < allAccounts.Length; i++)
            {
                if (account.login == allAccounts[i].login)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
