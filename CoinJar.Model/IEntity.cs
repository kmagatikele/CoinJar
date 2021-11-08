using System;

namespace CoinJar.Model
{
    public interface IEntity
    {
        Guid? Id { get; set; }
    }
}
