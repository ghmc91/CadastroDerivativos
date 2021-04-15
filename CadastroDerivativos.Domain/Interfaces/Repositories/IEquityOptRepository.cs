using CadastroDerivativos.Domain.Entities.EquityOpt;
using System.Collections.Generic;

namespace CadastroDerivativos.Domain.Interfaces
{
    public interface IEquityOptRepository
    {
        public IEnumerable<EquityOptions> GetEquityOpts();
        public IEnumerable<OptInstrument> GetOptInstrument();
        public IEnumerable<OptMarket> GetOptMarket();
        public IEnumerable<Maturity> GetMaturities(string market);

    }
}
