using PG.Model;
using TinyCsvParser.Mapping;

namespace PG.Data
{
    public class CsvTransactionMapping : CsvMapping<Transaction>
    {
        public CsvTransactionMapping() : base()
        {
            MapProperty(0, x => x.Date);
            MapProperty(1, x => x.Description);
            MapProperty(2, x => x.Deposit);
            MapProperty(3, x => x.Withdrawls);
            MapProperty(4, x => x.Balance);
        }
    }
}
