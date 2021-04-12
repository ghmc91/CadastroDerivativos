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
            try
            {
                var equityOpts = CadastroDerivativos.Data.Csv.CsvReader.Read<EquityOpt, EquityOptMapping>(
                    "C:\\Users\\Asus\\Desktop\\to_upload\\Ticker_Off.csv", ",", Encoding.Default, "pt-BR");

                equityOpts.ToList().ForEach(x =>
                {
                    Console.WriteLine(x.Ticker + " - " + x.Style);
                });

 }
            catch (FieldValidationException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
