using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace CadastroDerivativos.Domain.Entities.EquityOpt
{
    public class EquityOptions
    {
        public EquityOptions()
        {

        }

        public EquityOptions(string ticker,
                         string instrument,
                         decimal strike,
                         string payout,
                         DateTime maturity,
                         string style,
                         string market)
        {
            Ticker = ticker;
            Instrument = instrument;
            Strike = strike;
            Payout = payout;
            Market = market;
            Maturity = maturity;
            Style = style;
        }
        public string Ticker { get; set; }
        public string Instrument { get; set; }
        public string MaturityLabel { get; set; }
        public decimal Strike { get; set; }
        public string Payout { get; set; }
        public string Style { get; set; }
        public DateTime Maturity { get; set; }
        public string Market { get; set; }

        public EquityOptions LoadData(string ticker,
                                  IEnumerable<OptInstrument> optInstruments,
                                  IEnumerable<OptMarket> optMarkets)
        {
            var active = ticker.Split()[0];
            var instrument = optInstruments.Where(x => x.Ticker.Equals(active))
                                          .Select(i => i.Instrument).FirstOrDefault();

            var market = optMarkets.Where(x => x.Ticker.Equals(active))
                                  .Select(i => i.Market).FirstOrDefault();

            var tickerSplit = ticker.Split();
            var date = tickerSplit[tickerSplit.Length - 2];
            var maturity = Convert.ToDateTime(date, CultureInfo.InvariantCulture);

            var style = market.Equals("US NYSE") ? "A" : "E";
            var payoutStrike = ticker.Split().Last();
            var payout = payoutStrike[0].ToString();
            var strike = Convert.ToDecimal(payoutStrike.Remove(0, 1));

            var equityOpt = new EquityOptions(ticker, instrument, strike, payout, maturity, style, market);
            return equityOpt;

        }

        public EquityOptions GetMaturityLabel(IEnumerable<Maturity> maturities, EquityOptions equityOpt)
        {
            var maturityLabel = maturities.Where(x => x.MaturityDate.Equals(equityOpt.Maturity))
                                          .Select(i => i.Label).FirstOrDefault();
            equityOpt.MaturityLabel = maturityLabel;
            return equityOpt;
        }
    }
}
