using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PG.Model
{
    public class Transaction
    {
        public DateTime Date  { get; set; }
        public string  Description { get; set;  }
        public double Deposit { get; set; }
        public double Withdrawls { get; set;  }
        public double Balance { get; set;  }

    }
}
