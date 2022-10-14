using System.IO;

namespace PG.Data
{
    public class CsvReader
    {
        private TextReader reader;

        public CsvReader(TextReader reader)
        {
            this.reader = reader;
        }
    }
}