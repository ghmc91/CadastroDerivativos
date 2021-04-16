using CadastroDerivativos.Domain.Entities.EquityOpt;
using CsvHelper.Configuration;

namespace CadastroDerivativos.Infra.Data.Mappings
{
    public class TickersGustavexMapping : ClassMap<TickerGustavex>
    {
        public TickersGustavexMapping()
        {
            Map(x => x.Ticker);
        }
    }
}
