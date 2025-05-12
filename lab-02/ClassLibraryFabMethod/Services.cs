using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFabMethod
{
    public class WebSite : ISubCreator
    {
        public Subscription CreateSubscription()
        {
            Console.WriteLine("[WebSite] Користувач вибирає підписку через веб-інтерфейс...");
            return new DomesticSubscription();
        }
    }

    public class MobileApp : ISubCreator
    {
        public Subscription CreateSubscription()
        {
            Console.WriteLine("[MobileApp] Користувач отримує персоналізовані рекомендації...");
            return new EducationalSubscription();
        }
    }

    public class ManagerCall : ISubCreator
    {
        public Subscription CreateSubscription()
        {
            Console.WriteLine("[ManagerCall] Менеджер телефонує і пропонує спеціальні умови...");
            return new PremiumSubscription();
        }
    }
}
