using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelSync
{
    public class PaymentTermsReport
    {
        public List<IPaymentTerm> ExcelOnlyTerms { get; set; }
        public List<IPaymentTerm> QBOnlyTerms { get; set; }
        public List<ConflictPaymentTerms> InconsistentTerms { get; set; }
    }
}
