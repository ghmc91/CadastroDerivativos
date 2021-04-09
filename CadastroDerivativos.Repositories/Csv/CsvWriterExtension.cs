using CsvHelper;
using CsvHelper.Configuration;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace CadastroDerivativos.Data.Csv
{
    public static class CsvWriterExtension
    {
        public static void ToCsv<TMapping, TModel>(this IEnumerable<TModel> items,
                                                   string fullname,
                                                   string separator,
                                                   Encoding encoding,
                                                   string culture)
            where TMapping : ClassMap, new()
        {
            var inputFileDescription = new CsvConfiguration(new CultureInfo(culture))
            {
                Delimiter = separator,
                Encoding = encoding,
                IgnoreBlankLines = true
            };

            using (var sr = new StreamWriter(fullname))
            using (var csv = new CsvWriter(sr, inputFileDescription))
            {
                csv.Context.RegisterClassMap<TMapping>();
                csv.WriteRecords(items);
            }
        }
    }
}
