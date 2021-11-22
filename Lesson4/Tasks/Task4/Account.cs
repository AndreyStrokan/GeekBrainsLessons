namespace Lesson4.Tasks.Task4
{
    internal struct Account
    {
        public string login;
        public string password;

        public Account(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public override bool Equals(object obj)
        {
            Account otherAccout = (Account) obj;
            if (otherAccout.login == login && otherAccout.password == password)
            {
                return true;
            }
            return false;
        }


        public override string ToString()
        {
            return $"Login: {login} | Password: {password}";
        }
    }
}
