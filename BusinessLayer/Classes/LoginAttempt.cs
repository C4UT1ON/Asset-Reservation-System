namespace BusinessLayer.Classes
{
    // class used only to pass the data from the login attempt into the database
    public class LoginAttempt{

        public readonly string Username;
        public readonly string Password;

        public LoginAttempt()
        { 
        }

        public LoginAttempt(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

    }
}