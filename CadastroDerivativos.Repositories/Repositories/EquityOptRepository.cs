using CadastroDerivativos.Data.Csv;
using CadastroDerivativos.Data.Mappings;
using CadastroDerivativos.Domain.Entities;
using CadastroDerivativos.Domain.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace CadastroDerivativos.Data.Repositories
{
    public class EquityOptRepository : IEquityOptInterface
    {
 
        public IEnumerable<EquityOpt> GetEquityOpts()
        {
            return CsvReader.Read<EquityOpt, EquityOptMapping>("C:\\Users\\Asus\\Documents\\Bases\\EquityOpt\\Base\\Ticker_Off.csv", ", ", Encoding.Default, "pt-BR");
        }

        public IEnumerable<EquityOptAux> GetEquityOptsAux()
        {
            return CsvReader.Read<EquityOptAux, EquityOptAuxMapping>("C:\\Users\\Asus\\Documents\\Bases\\EquityOpt\\BasesAux\\Ticker_Off_Reduced.csv, ", ", Encoding.Default, "pt-BR");
        }
    }
}
