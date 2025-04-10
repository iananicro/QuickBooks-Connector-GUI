using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExcelSync
{
    public interface IPaymentTerm
    {
        string Name { get; set; }
        string ExcelID { get; set; }
        Status status { get; set; }
    }

    public enum Status
    {
        Unprocessed,
        Succeeded,
        Failed
    }
}
