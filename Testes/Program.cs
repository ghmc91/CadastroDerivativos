using CadastroDerivativos.Data.Csv;
using CadastroDerivativos.Data.Mappings;
using CadastroDerivativos.Domain.Entities;
using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Testes
{
    class Program
    {
        static void Main(string[] args)
        {
            var ticker = "EWZ US 04/16/21 C144 Equity";
            var tickerSplit = ticker.Split();
            var maturtiy = tickerSplit[tickerSplit.Length - 3];
            var date = Convert.ToDateTime(maturtiy, CultureInfo.InvariantCulture);
            var date2 = DateTime.Parse(date.ToShortDateString(), CultureInfo.GetCultureInfo("pt-BR"));
            Console.WriteLine(date2);
        }
    }
}
