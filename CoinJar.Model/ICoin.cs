using System;

namespace CoinJar.Model
{
    public interface ICoin : IEntity
    {
        decimal Amount { get; set; }
        decimal Volume { get; set; }
    }
}
