using CadastroDerivativos.Domain.Entities.EquityOpt;
using CsvHelper.Configuration;

namespace CadastroDerivativos.Infra.Data.Mappings
{
    public class MaturityMapping : ClassMap<Maturity>
    {
        public MaturityMapping()
        {
            Map(x => x.Label);
            Map(x => x.MaturityDate).Name("Maturity");
        }
    }
}
