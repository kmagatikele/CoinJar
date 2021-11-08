using CoinJar.Model;
using CoinJar.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CoinJar.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoinJarController : BaseController<Coin, CoinJarRepository>
    {
        public CoinJarController(CoinJarRepository repository) : base(repository)
        {

        }

        [HttpPost("add")]
        public async Task<ActionResult> Add(Coin coin)
        {
            coin.Id = Guid.NewGuid();
            await repository.Add(coin);
            return Ok();
        }

        [HttpGet("total")]
        public async Task<ActionResult> GetTotal()
        {
            var total = await repository.GetTotalAmount();
            return Ok(total.ToString("C2"));
        }

        [HttpDelete("reset")]
        public async Task<ActionResult> Reset()
        {
            await repository.Reset();
            return Ok();
        }
    }
}
