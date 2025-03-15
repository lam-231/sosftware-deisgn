using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFabMethod
{
    public class DomesticSubscription : Subscription
    {
        public DomesticSubscription() : base("Domestic", 14.99m, 3, new List<string> {"1+1", "ТЕТ", "Інтер", "UA"}, new List<string> { "HD Streaming" }) { }
    }

    public class EducationalSubscription : Subscription
    {
        public EducationalSubscription() : base("Educational", 9.99m, 6, new List<string> {"Discovery", "Перший науковий"}, new List<string> { "Ad-Free", "HD Streaming"}) { }
    }

    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription() : base("Premium", 19.99m, 6, new List<string> { "1+1", "ТЕТ", "Інтер", "UA", "Discovery", "Перший науковий", "Sport1" }, new List<string> { "4K Streaming", "Multi-Device Support", "Ad-Free"}) { }
    }
}
