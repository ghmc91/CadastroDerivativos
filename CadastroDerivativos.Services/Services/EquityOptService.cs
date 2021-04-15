using CadastroDerivativos.Domain.Entities.EquityOpt;
using CadastroDerivativos.Domain.Interfaces;
using CadastroDerivativos.Domain.Interfaces.Services;
using System;
using System.Linq;

namespace CadastroDerivativos.Application.Services
{
    public class EquityOptService : IEquityOptService
    {
        private readonly IEquityOptRepository _equityOptRepository;

        public EquityOptService(IEquityOptRepository equityOptRepository)
        {
            _equityOptRepository = equityOptRepository;
        }

        public string GetActive(string ticker)
        {
            return ticker.Split()[0];
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

        public bool HasInstrument(string ticker)
        {
            var instrumentTicker = _equityOptRepository.GetOptInstrument();
            var active = GetActive(ticker);
            return instrumentTicker.Where(x => x.Ticker.Equals(active)).Any();
        }

        public bool HasMarket(string ticker)
        {
            var marketTicker = _equityOptRepository.GetOptMarket();
            var active = GetActive(ticker);
            return marketTicker.Where(x => x.Ticker.Equals(active)).Any();
        }

        public bool HasTickerInBase(string ticker)
        {
            var equityOpts = _equityOptRepository.GetEquityOpts();
            return equityOpts.Where(x => x.Ticker.Equals(ticker)).Any();
        }
    }
}
