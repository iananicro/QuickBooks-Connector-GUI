using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelSync
{
    public class ConflictPaymentTerms
    {
        public IPaymentTerm excelTerm { get; set; }
        public IPaymentTerm qbTerm { get; set; }
    }
}
