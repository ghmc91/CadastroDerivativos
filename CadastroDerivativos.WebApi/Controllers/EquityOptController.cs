using CadastroDerivativos.Domain.Entities.EquityOpt;
using CadastroDerivativos.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace CadastroDerivativos.WebApiAngular.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EquityOptController : ControllerBase
    {
        private readonly IEquityOptService _equityOptService;
        private readonly ILogger<EquityOptions> _logger;

        public EquityOptController(IEquityOptService equityOptService, ILogger<EquityOptions> logger)
        {
            _equityOptService = equityOptService;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<EquityOptions> Get()
        {
            return _equityOptService.GetEquityOpts().ToArray();
        }
    }
}
