using ClassLibraryAuthenticator;
class Program
{
    static void Main()
    {
        Thread thread1 = new Thread(() =>
        {
            Authenticator auth1 = Authenticator.GetInstance();
            auth1.Authenticate("Anatoly", "unbeliveablepASS");
        });

        Thread thread2 = new Thread(() =>
        {
            Authenticator auth2 = Authenticator.GetInstance();
            auth2.Authenticate("Romchuk", "7ate9");
        });

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();
    }
}
