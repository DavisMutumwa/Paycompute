using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Paycompute_Services.Implementation
{
    public class TaxService : ItaxService
    {
        private decimal taxRate;
        public decimal tax;
        public decimal TaxAmount(decimal totalAmount)
        {
            if(totalAmount <= 1042)
            {
                //tax Free Rate
                taxRate = .0m;
                tax =totalAmount * taxRate;
            }
            else if(totalAmount > 1042 && totalAmount < + 3125)
            {
                //Basic tax rate
                taxRate = .20m;
                //Income tax
                tax = (1042 * .0m) + ((totalAmount - 1042) * taxRate);

            }
            else if (totalAmount >  3125 && totalAmount<= 12500)
            {
                //Higher tax
                taxRate = .40m;
                //income
                tax =(1042* .0m) + ((3125 -1042) * .20m) +((totalAmount - 3125)*taxRate);
            }
            else if(totalAmount> 12500)
            {
                //Additional tax Rate
                taxRate = .45m;
                //Income tax
                tax = (1042 * .0m) + ((3125 - 1042) * .20m) + ((12500 - 3125) * .40m) + ((totalAmount - 12500) * taxRate);
            }
            return taxRate;
        }

    }
}
