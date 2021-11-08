using System;

namespace CoinJar.Model
{
    public class Coin : ICoin
    {
        public Guid? Id { get; set; }
        public decimal Amount { get; set; }
        public decimal Volume { get; set; }
    }
}
