using CadastroDerivativos.Domain.Entities.ApiResult;
using CadastroDerivativos.Domain.Entities.EquityOpt;
using CadastroDerivativos.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CadastroDerivativos.WebApiAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquityOptController : ControllerBase
    {
        private readonly IEquityOptService _equityOptService;

        public EquityOptController(IEquityOptService equityOptService)
        {
            _equityOptService = equityOptService;
        }

        //[HttpGet("{ticker}")]
        //public void CheckTicker(string ticker)
        //{
        //    var newTicker = System.Net.WebUtility.UrlDecode(ticker);
        //    newTicker = newTicker.Remove(newTicker.LastIndexOf(' ')).TrimEnd().ToUpper();
        //    var x = _equityOptService.GetTickers();
        //    var y = _equityOptService.GetEquityOpts();
        //}

        [HttpGet]
        public IEnumerable<EquityOptions> GetEquityOpt()
        {
            return _equityOptService.GetEquityOpts();
        }
    }
}
