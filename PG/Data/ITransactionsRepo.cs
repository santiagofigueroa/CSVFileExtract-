using System.Collections.Generic;
using PG.Model; 

namespace PG.Data
{
    public interface ITransactionsRepo
    {
        public IEnumerable<Transaction> GetAllTransaction();
    }
}