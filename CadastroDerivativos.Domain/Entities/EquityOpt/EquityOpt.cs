using System;

namespace CadastroDerivativos.Domain.Entities
{
    public class EquityOpt
    {
        public string Ticker { get; set; }
        public string Instrument { get; set; }
        public string MaturityLabel { get; set; }
        public decimal Strike { get; set; }
        public string Payout { get; set; }
        public string Style { get; set; }
        public DateTime Maturity { get; set; }
        public string Market { get; set; }
    }

    public class OptInstrument
    {
        public string Ticker { get; set; }
        public string Instrument { get; set; }
    }

    public class OptMarket
    {
        public string Ticker { get; set; }
        public string Market { get; set; }
    }
}
