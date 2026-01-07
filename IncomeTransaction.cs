using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalCashLedger
{
    public class IncomeTransaction : Transaction
    {

        public string? Source { get; set; }
        public override string GetSummary()
        {
            return $"[Income] {Date.ToShortDateString()} | {Source} | ${Amount} | {Description}";
        }
    }
}
