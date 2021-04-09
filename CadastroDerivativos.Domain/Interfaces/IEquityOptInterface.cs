using CadastroDerivativos.Domain.Entities;
using System.Collections.Generic;

namespace CadastroDerivativos.Domain.Interfaces
{
    public interface IEquityOptInterface
    {
        public IEnumerable<EquityOpt> GetEquityOpts();
        public IEnumerable<EquityOptAux> GetEquityOptsAux();

    }
}
