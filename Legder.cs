using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalCashLedger
{
    public class Legder<T> where T : Transaction
    {

        //This is the local list to store the transaction
        private List<T> entries;

        public List<T> GetEntries()
        {
            return entries;
        }


        public Legder()
        {
            entries = new List<T>();
        }

        // This add the transaction to the list
        public void AddEntry(T entry)
        {
            entries.Add(entry);

        }


        /// <summary>
        /// This method takes the date as parameter and search the entry list 
        /// if the date found add the entry to the res and print the list.
        /// </summary>
        /// <param name="date"></param>
        /// <returns>List</returns>

        public List<T> GetTransactionByDate(DateTime date)
        {
            //local variable to store the list
            List<T> result = new List<T>();
            foreach(T entry in entries)
            {
                if(entry.Date == date.Date)
                {
                    result.Add(entry);
                }
                else
                {
                    Console.WriteLine("Transaction not Found!!");
                    continue;
                }
            }

            return result;

        }

        //This Method calculates the Total Expense of that transaction and store it as total.
        public decimal CalculateTotal()
        {
            decimal total = 0;

            foreach (T entry in entries)
            {
                total += entry.Amount;
            }

            return total;

        }
    }
}
