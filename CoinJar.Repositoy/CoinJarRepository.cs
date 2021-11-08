using CoinJar.Model;
using System.Linq;
using System.Threading.Tasks;

namespace CoinJar.Repository
{
    public class CoinJarRepository : GenericRepository<Coin, ApplicationContext>, ICoinJarRepository
    {
        public CoinJarRepository(ApplicationContext context) : base(context) {}

        public async Task AddCoin(Coin coin)
        {
            await Add(coin);
        }


        public async Task<decimal> GetTotalAmount()
        {
            decimal total = 0;
            var coins = await GetAll();
            if (coins.Count > 0)
                total = coins.Sum(x => x.Amount);

            return total;
        }

        public async Task Reset()
        {
            var coins = await GetAll();

            foreach (var coin in coins)
                await Delete(coin.Id.Value);
        }
    }
}
