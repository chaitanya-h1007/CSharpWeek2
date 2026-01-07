using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalCashLedger
{

    /// <summary>
    /// IReportable is a interface with GetSummary Method to be implemented by the all transactions
    /// </summary>
     public interface IReportable
    {
        
        string GetSummary();
    }
}
