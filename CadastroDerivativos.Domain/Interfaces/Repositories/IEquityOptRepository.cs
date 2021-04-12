using CadastroDerivativos.Domain.Entities;
using System.Collections.Generic;

namespace CadastroDerivativos.Domain.Interfaces
{
    public interface IEquityOptRepository
    {
        public IEnumerable<EquityOpt> GetEquityOpts();
        public IEnumerable<OptInstrument> GetOptInstrument();
        public IEnumerable<OptMarket> GetOptMarket();

    }
}
