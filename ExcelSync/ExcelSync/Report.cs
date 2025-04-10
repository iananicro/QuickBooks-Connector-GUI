using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelSync
{
    public class Report
    {
        public PaymentTermsReport TermsReport { get; set; }

        public static void WriteReport()
        {
            // write report to an excel file (.xlsx)
            // example report

            // If there are unsolved conflicts, then print
            // "Following payment terms conflicts failed to resolve. Need manual intervention"
            // then print the details in red
            // "payment term 'Net 30' exist in Quickbooks but not in Beulah. It was failed to be deleted from Quickbooks. Please address it manually."


            // if some terms have been successfully handled, then print
            // "Following payment term conflicts have been automatically solved. No need for manual intervention."
            // then print the details like below 
            // "payment term 'Net 15' exist in Beulah and not in Quickbooks. It has been successfully added to Quickbooks."
            // "payment term 'Net 60' exist in both Beulah and Quickbooks, but with different names. It has been sucessfully renamed to 'Net 60'."
        }
    }
}
