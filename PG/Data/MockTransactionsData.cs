using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using PG.Model;
using TinyCsvParser;
using TinyCsvParser.Mapping;

namespace PG.Data
{
    public class MockTransactionsData : ITransactionsRepo
    {
        private readonly List<CsvMappingResult<Transaction>> _records;

        // private readonly string _records; 
        //private string []  _records;


        public MockTransactionsData()
        {
            try
            {
                CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');
                //
                CsvTransactionMapping csvMapping = new CsvTransactionMapping();
                // 
                var csvParser = new CsvParser<Transaction>(csvParserOptions, csvMapping);
                //               
                // Reading parser for CSV.
                var csvReaderOptions = new CsvReaderOptions(new[] { "/n" });

                var records = csvParser.ReadFromFile("./CSV/C.csv", Encoding.UTF8);

                var result =
                    records
                    .ToList(); //results is empty here!

                _records = result;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                // TOOO: Close file if need be.

            }


        }

        public IEnumerable<Transaction> GetAllTransaction()
        {

            try
            {

                // New list  where we going to place the the CSV results.

                var transcations = new List<Transaction>();

                _records
                    .ForEach(x => transcations.Add(new Transaction
                    {
                        Date = x.Result.Date,
                        Description = x.Result.Description,
                        Deposit = x.Result.Deposit,
                        Withdrawls = x.Result.Withdrawls,
                        Balance = x.Result.Balance

                    }));


                return transcations;

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }





    }
}
