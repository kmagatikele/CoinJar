using CoinJar.Model;
using System.Threading.Tasks;

namespace CoinJar.Repository
{
    public interface ICoinJarRepository
    {
        Task AddCoin(Coin coin);
        Task<decimal> GetTotalAmount();
        Task Reset();
    }
}
