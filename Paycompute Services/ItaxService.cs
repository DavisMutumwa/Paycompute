using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paycompute_Services
{
    public interface ItaxService
    {
        decimal TaxAmount(decimal totalAmount);
    }
}
