using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalCashLedger
{
    public class ExpenseTransaction : Transaction
    {

        public string Category { get; set; }
        public override string GetSummary()
        {
            return $"[EXPENSE] {Date.ToShortDateString()} | {Category} | ${Amount} | {Description}";
        }


    }
}
