using CadastroDerivativos.Domain.Entities.EquityOpt;
using System.Collections.Generic;

namespace CadastroDerivativos.Domain.Interfaces
{
    public interface IEquityOptRepository
    {
        IEnumerable<EquityOptions> GetEquityOpts();
        IEnumerable<OptInstrument> GetOptInstrument();
        IEnumerable<OptMarket> GetOptMarket();
        IEnumerable<Maturity> GetMaturities(string market);
        IEnumerable<TickerGustavex> GetTickers();
    }
}
