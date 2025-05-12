namespace SupportLibrary
{
    public abstract class SupportHandler
    {
        protected SupportHandler? next;

        public void SetNext(SupportHandler nextHandler)
        {
            next = nextHandler;
        }

        public void StartSupport()
        {
            if (!AskUser())
            {
                if (next != null)
                    next.StartSupport();
                else
                    Console.WriteLine("Не вдалося визначити рiвень пiдтримки. Спробуйте ще раз.");
            }
        }

        protected abstract bool AskUser();
    }
}
