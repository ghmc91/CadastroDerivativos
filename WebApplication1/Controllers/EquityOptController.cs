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

        [HttpPost("{ticker}")]
        public bool CheckTicker(string ticker)
        {
            return _equityOptService.hasTicker(ticker);
        }
    }
}
