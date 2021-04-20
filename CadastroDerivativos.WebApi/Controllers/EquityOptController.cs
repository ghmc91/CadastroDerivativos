using CadastroDerivativos.Domain.Entities.EquityOpt;
using CadastroDerivativos.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CadastroDerivativos.WebApiAngular.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EquityOptController : ControllerBase
    {
        private readonly IEquityOptService _equityOptService;

        public EquityOptController(IEquityOptService equityOptService)
        {
            _equityOptService = equityOptService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<EquityOptions>> GetEquityOpt()
        {
            return Ok(_equityOptService.GetEquityOpts());
        }
    }
}
