using CadastroDerivativos.Data.Csv;
using CadastroDerivativos.Data.Mappings;
using CadastroDerivativos.Domain.Entities;
using CadastroDerivativos.Domain.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace CadastroDerivativos.Data.Repositories
{
    public class EquityOptRepository : IEquityOptRepository
    {
 
        public IEnumerable<EquityOpt> GetEquityOpts()
        {
            return CsvReader.Read<EquityOpt, EquityOptMapping>("C:\\Users\\Asus\\Documents\\Bases\\EquityOpt\\Base\\Ticker_Off.csv", ",", Encoding.Default, "pt-BR");
        }

        public IEnumerable<OptInstrument> GetOptInstrument()
        {
            return CsvReader.Read<OptInstrument, OptInstrumentMapping>("C:\\Users\\Asus\\Documents\\Bases\\EquityOpt\\Bases_Aux\\Instrument_Ticker.csv", ",", Encoding.Default, "pt-BR");
        }

        public IEnumerable<OptMarket> GetOptMarket()
        {
            return CsvReader.Read<OptMarket, OptMarketMapping>("C:\\Users\\Asus\\Documents\\Bases\\EquityOpt\\Bases_Aux\\Market_Ticker.csv", ",", Encoding.Default, "pt-BR");
        }
    }
}
