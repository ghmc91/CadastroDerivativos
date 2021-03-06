using CadastroDerivativos.Data.Csv;
using CadastroDerivativos.Data.Mappings;
using CadastroDerivativos.Domain.Entities;
using CadastroDerivativos.Domain.Entities.EquityOpt;
using CadastroDerivativos.Domain.Interfaces;
using CadastroDerivativos.Infra.Data.Mappings;
using System.Collections.Generic;
using System.Text;

namespace CadastroDerivativos.Data.Repositories
{
    public class EquityOptRepository : IEquityOptRepository
    {
 
        public IEnumerable<EquityOptions> GetEquityOpts()
        {
            return CsvReader.Read<EquityOptions, EquityOptMapping>("C:\\Users\\Asus\\Documents\\Bases\\EquityOpt\\Base\\Ticker_Off.csv", ",", Encoding.Default, "pt-BR");
        }

        public IEnumerable<Maturity> GetMaturities(string market)
        {
            market = market.Replace(" ", "_");
            return CsvReader.Read<Maturity, MaturityMapping>("C:\\Users\\Asus\\Documents\\Bases\\EquityOpt\\Maturity\\" + market + ".csv", ",", Encoding.Default, "pt-BR");
        }

        public IEnumerable<OptInstrument> GetOptInstrument()
        {
            return CsvReader.Read<OptInstrument, OptInstrumentMapping>("C:\\Users\\Asus\\Documents\\Bases\\EquityOpt\\BasesAux\\Instrument_Ticker.csv", ",", Encoding.Default, "pt-BR");
        }

        public IEnumerable<OptMarket> GetOptMarket()
        {
            return CsvReader.Read<OptMarket, OptMarketMapping>("C:\\Users\\Asus\\Documents\\Bases\\EquityOpt\\BasesAux\\Market_Ticker.csv", ",", Encoding.Default, "pt-BR");
        }

        public IEnumerable<TickerGustavex> GetTickers()
        {
            return CsvReader.Read<TickerGustavex, TickersGustavexMapping>("C:\\Users\\Asus\\Documents\\Bases\\EquityOpt\\Gustavex\\Gustavex.csv", ",", Encoding.Default, "pt-BR");
        }
    }
}
