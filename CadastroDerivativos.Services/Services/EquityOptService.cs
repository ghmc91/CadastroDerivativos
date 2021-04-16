using CadastroDerivativos.Domain.Entities.EquityOpt;
using CadastroDerivativos.Domain.Interfaces;
using CadastroDerivativos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
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
            var equityOpt = new EquityOptions();
            equityOpt = equityOpt.LoadData(ticker, instrument, market);
            var maturities = _equityOptRepository.GetMaturities(equityOpt.Market);
            var equityOptsFull = equityOpt.GetMaturityLabel(maturities, equityOpt);
            return equityOptsFull;
        }

        public IEnumerable<EquityOptions> GetEquityOpts()
        {
            var tickers = GetTickers().ToList();
            var market = _equityOptRepository.GetOptMarket();
            var instrument = _equityOptRepository.GetOptInstrument();
            var equityOpt = new EquityOptions();
            List<EquityOptions> equitiesOpts = new List<EquityOptions>();
            tickers.ForEach(x =>            
            {
                var newTicker = x.Ticker.Remove(x.Ticker.LastIndexOf(' ')).TrimEnd();
                equityOpt = equityOpt.LoadData(newTicker, instrument, market);
                var maturities = _equityOptRepository.GetMaturities(equityOpt.Market);
                var equityOptsFull = equityOpt.GetMaturityLabel(maturities, equityOpt);
                equitiesOpts.Add(equityOptsFull);
            });
            return equitiesOpts;
        }

        public DateTime GetMaturity(string ticker)
        {
            var maturity = ticker[ticker.Length - 2];
            return DateTime.Now;
        }

        public IEnumerable<TickerGustavex> GetTickers()
        {
            return _equityOptRepository.GetTickers();
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
