using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;

namespace CadastroDerivativos.Data.Csv
{
    public static class CsvReader
    {
        public static IEnumerable<TModel> Read<TModel, TMapping>(string path, string separator, Encoding encoding,
                                                                string culture, bool firstLineHasColumn = true)
        where TModel : class, new()
        where TMapping : ClassMap, new()
        {
            var records = new List<TModel>();
            var inputFileDescription = new CsvConfiguration(new CultureInfo(culture))
            {
                Delimiter = separator,
                HasHeaderRecord = firstLineHasColumn,
                Encoding = encoding,
                IgnoreBlankLines = true
            };

            using (var fs = new StreamReader(path))
            using(var csv = new CsvHelper.CsvReader(fs, inputFileDescription))
            {
                csv.Context.RegisterClassMap<TMapping>();
                records = csv.GetRecords<TModel>().ToList();
            }

            return records;
        }
    }
}
