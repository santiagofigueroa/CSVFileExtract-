using System;
using PG.Model;
using PG.Data;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace PG.Controller
{
    [Route("api/transactions")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        // https://dotnetcoretutorials.com/2018/08/04/csv-parsing-in-net-core/ More references here.

        // Injection

        private readonly ITransactionsRepo _context;

        public TransactionController(ITransactionsRepo context)
        {
            _context = context; 
        }


        [HttpGet]
        public IEnumerable<Transaction> GetAllTrasactions()
        {

            return _context.GetAllTransaction();        
        
        }
    }
}
