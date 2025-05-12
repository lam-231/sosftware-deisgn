namespace ClassLibraryAuthenticator
{
    sealed public class Authenticator
    {
        private static readonly object lockObject = new object();
        private static Authenticator? instance;

        private Authenticator()
        {
            Console.WriteLine("Authenticator instance created.");
        }

        public static Authenticator GetInstance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new Authenticator();
                    }
                }
            }
            return instance;
        }

        public void Authenticate(string username, string password)
        {
            Console.WriteLine($"Authenticating user: {username}");
        }
    }
}
