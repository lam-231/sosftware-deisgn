using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFabMethod
{
    public abstract class Subscription
    {
        public string Name { get; }
        public decimal MonthlyFee { get; }
        public int MinimumPeriod { get; }
        public List<string> Channels { get; }
        public List<string> Features { get; }

        protected Subscription(string name, decimal monthlyFee, int minimumPeriod, List<string> channels, List<string> features)
        {
            Name = name;
            MonthlyFee = monthlyFee;
            MinimumPeriod = minimumPeriod;
            Channels = channels;
            Features = features;
        }

        public override string ToString()
        {
            return $"Підписка: {Name}, " +
                $"Місячна оплата: {MonthlyFee:C}, " +
                $"Мінімальний період: {MinimumPeriod} months\n" +
                $"Список каналів: {string.Join(", ", Channels)}\n" +
                $"Можливості: {string.Join(", ", Features)}\n";
        }
    }
}
