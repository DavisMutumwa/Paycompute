using Paycompute.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebPages.Html;

namespace Paycompute_Services
{
    public interface IPayComputationService
    {
        Task CreateAsync(PaymentRecord paymentRecord);
        PaymentRecord GetById(int id);
        TaxYear GetTaxYearById(int id);
        IEnumerable<PaymentRecord> GetAll();
        IEnumerable<SelectListItem> GetAllTaxYear();
        decimal OvertimeHours(decimal hoursWorked, decimal contractualHours);
        decimal ContractualEarnings(decimal contractualHours, decimal hoursWorked,decimal hourlyRate);
        decimal OvertimeEarnings(decimal overtimeRate, decimal overtimeHours);
        decimal OvertimeRate(decimal hourlyRate);
        decimal TotalEarnings(decimal overtmeEarnings, decimal contract);
        decimal TotalDeduction(decimal Tax, decimal nic, decimal studentLoanRepayment, decimal unionFees);
        decimal NetPay(decimal totalEarnings,decimal totalDeductions);
    }
}
