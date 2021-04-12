using CadastroDerivativos.Domain.Entities;
using CsvHelper.Configuration;

namespace CadastroDerivativos.Data.Mappings
{
    public class EquityOptMapping : ClassMap<EquityOpt>
    {
        public EquityOptMapping()
        {
            Map(x => x.Ticker);
            Map(x => x.Instrument);
            Map(x => x.MaturityLabel).Name("Maturity Label");
            Map(x => x.Strike);
            Map(x => x.Payout);
            Map(x => x.Style);
            Map(x => x.Maturity).TypeConverterOption.Format("dd/MM/yyyy");
            Map(x => x.Market);
        }
    }

    public class OptInstrumentMapping : ClassMap<OptInstrument>
    {
        public OptInstrumentMapping()
        {
            Map(x => x.Ticker);
            Map(x => x.Instrument);
        }
    }

    public class OptMarketMapping : ClassMap<OptMarket>
    {
        public OptMarketMapping()
        {
            Map(x => x.Ticker);
            Map(x => x.Market);
        }
    }
    

}

