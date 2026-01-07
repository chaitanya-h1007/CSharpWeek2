using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalCashLedger
{
    public abstract class Transaction : IReportable
    {
        
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }

        public abstract string GetSummary();
        
    }
}
