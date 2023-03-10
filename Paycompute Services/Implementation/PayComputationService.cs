using Paycompute.Entity;
using PayCompute.Percistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebPages.Html;

namespace Paycompute_Services.Implementation
{
    public class PayComputationService : IPayComputationService
    {
        private decimal contractualEarnings;
        private decimal overtimeHours;
        private readonly ApplicationDbContext _context;
        

        public PayComputationService(ApplicationDbContext context)
        {
            _context = context;
        }
        public decimal ContractualEarnings(decimal contractualHours, decimal hoursWorked, decimal hourlyRate)
        {
            if(hoursWorked < contractualHours)
            {
                contractualEarnings = hoursWorked * hourlyRate;
            }
            else
            {
                contractualEarnings = contractualHours * hourlyRate;
            }
            return contractualEarnings;
        }

        public async Task CreateAsync(PaymentRecord paymentRecord)
        {
           await _context.PaymentRecords.AddAsync(paymentRecord);
           await _context.SaveChangesAsync();
        }

        public IEnumerable<PaymentRecord> GetAll() => _context.PaymentRecords.OrderBy(p => p.EmoployeeId);
     

        public IEnumerable<SelectListItem> GetAllTaxYear()
        {
            var allTaxYear = _context.TaxYears.Select(taxYears => new SelectListItem
            {
                Text = taxYears.YearOfTax,
                Value = taxYears.Id.ToString()
            });
            return allTaxYear;
        }

        public PaymentRecord GetById(int id) => _context.PaymentRecords.Where(Pay => Pay.Id == id).FirstOrDefault();
        

        public decimal NetPay(decimal totalEarnings, decimal totalDeductions) => totalEarnings  - totalDeductions;
      

        public decimal OvertimeHours(decimal hoursWorked, decimal contractualHours)

        {
            if(hoursWorked <= contractualHours)
            {
                overtimeHours = 0.00m;
            }
            else if(hoursWorked > contractualHours)
            {
                overtimeHours = hoursWorked -contractualHours;
            }
            return overtimeHours;
        }
        public decimal OvertimeRate(decimal hourlyRate) => hourlyRate * 1.5m;
        
        public decimal TotalDeduction(decimal Tax, decimal nic, decimal studentLoanRepayment, decimal unionFees)
        
            => Tax + nic + studentLoanRepayment + unionFees;    
        public decimal TotalEarnings(decimal overtmeEarnings, decimal contract)
       
            => overtmeEarnings + contractualEarnings;

        public decimal OvertimeEarnings(decimal overtimeRate, decimal overtimeHours)
        
            => overtimeHours * overtimeRate;

        public TaxYear GetTaxYearById(int id)

        => _context.TaxYears.Where(GetAllTaxYear => GetAllTaxYear.Id == id).FirstOrDefault();
        
    }
}
