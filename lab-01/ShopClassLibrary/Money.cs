using System;

namespace ShopClassLibrary
{
    public class Money
    {
        private int _wholePart; 
        private int _coin; 

        public Money(int wholePart, int fractionalPart)
        {
            SetMoney(wholePart, fractionalPart);
        }

        public void SetMoney(int wholePart, int coin)
        {
            if (coin >= 100)
            {
                wholePart += coin / 100;
                coin %= 100;
            }
            _wholePart = wholePart;
            _coin = coin;
        }
        public override string ToString()
        {
            return $"{_wholePart}.{_coin:D2}";
        }
        public void DecreaseAmount(int wholePart, int coin)
        {
            int totalCents = _wholePart * 100 + _coin;
            int decreaseCents = wholePart * 100 + coin;
            totalCents -= decreaseCents;

            if (totalCents < 0)
            {
                return;
            }

            _wholePart = totalCents / 100;
            _coin = totalCents % 100;
        }
        public void Display()
        {
            Console.WriteLine($"{_wholePart}.{_coin:D2}");
        }
    }
}
