using CadastroDerivativos.Domain.Entities.EquityOpt;
using CadastroDerivativos.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace CadastroDerivativos.WebApi.Controllers
{
    [Route("api/equity")]
    [ApiController]
    public class EquityOptController : ControllerBase
    {
        private readonly IEquityOptService _equityOptService;

        public EquityOptController(IEquityOptService equityOptService)
        {
            _equityOptService = equityOptService;
        }

        [HttpGet("{ticker}")]
        public EquityOptions CheckTicker(string ticker)
        {
            var newTicker = System.Net.WebUtility.UrlDecode(ticker);
            newTicker = newTicker.Remove(newTicker.LastIndexOf(' ')).TrimEnd().ToUpper();
            return _equityOptService.GetEquityOpts(newTicker);
        }
    }
}
