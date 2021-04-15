using CadastroDerivativos.Domain.Entities.EquityOpt;
using System;

namespace CadastroDerivativos.Domain.Interfaces.Services
{
    public interface IEquityOptService
    {
        bool HasTickerInBase(string ticker);
        bool HasInstrument(string ticker);
        bool HasMarket(string ticker);
        string GetActive(string ticker);
        EquityOptions GetEquityOpts(string ticker);
    }
}
