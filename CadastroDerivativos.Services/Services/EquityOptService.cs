using CadastroDerivativos.Domain.Interfaces;
using CadastroDerivativos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CadastroDerivativos.Application.Services
{
    public class EquityOptService : IEquityOptService
    {
        private readonly IEquityOptRepository _equityOptRepository;

        public EquityOptService(IEquityOptRepository equityOptRepository)
        {
            _equityOptRepository = equityOptRepository;
        }

        public bool hasTicker(string ticker)
        {
            try
            {
                var tickerOff = _equityOptRepository.GetEquityOpts();
                return tickerOff.Where(x => x.Ticker.Equals(ticker)).Any();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
