using CadastroDerivativos.Domain.Entities.EquityOpt;
using CadastroDerivativos.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace CadastroDerivativos.WebApiAngular.Controllers
{
    [Route("api/equityopt")]
    [ApiController]
    public class EquityOptController : ControllerBase
    {
        private readonly IEquityOptService _equityOptService;

        public EquityOptController(IEquityOptService equityOptService)
        {
            _equityOptService = equityOptService;
        }

        [HttpGet("{ticker}")]
        public void CheckTicker(string ticker)
        {
            var newTicker = System.Net.WebUtility.UrlDecode(ticker);
            newTicker = newTicker.Remove(newTicker.LastIndexOf(' ')).TrimEnd().ToUpper();
            var x = _equityOptService.GetTickers();
            var y = _equityOptService.GetEquityOpts();
        }
    }
}
