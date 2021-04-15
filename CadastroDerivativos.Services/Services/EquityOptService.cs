using CadastroDerivativos.Domain.Entities.EquityOpt;
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

        public EquityOptions GetEquityOpts(string ticker)
        {
            var instrument = _equityOptRepository.GetOptInstrument();
            var market = _equityOptRepository.GetOptMarket();
            var equityOpts = new EquityOptions();
            equityOpts = equityOpts.LoadData(ticker, instrument, market);
            var maturities = _equityOptRepository.GetMaturities(equityOpts.Market);
            var equityOptsFull = equityOpts.GetMaturityLabel(maturities, equityOpts);
            return equityOptsFull;
        }

        public DateTime GetMaturity(string ticker)
        {
            var maturity = ticker[ticker.Length - 2];
            return DateTime.Now;

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
