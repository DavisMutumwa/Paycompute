using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Paycompute.Entity
{
    public class PaymentRecord
    {
        public int Id { get; set; }
        [ForeignKey("Employee")]
        public int EmoployeeId { get; set; }
        public Employee Employee { get; set; }
        [MaxLength(100)]
        public string FullName { get; set; }
        public string Nino { get; set; }
        public DateTime PayDate { get; set; }
        public string Paymonth { get; set; }
        [ForeignKey("TaxYear")]
        public int TaxYearId { get; set; }
        public TaxYear TaxYear { get; set; }
        public string Taxcode { get; set; }
        [Column(TypeName = "Money")]
        public decimal HourlyRate { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal HoursWorked { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal contractualHours { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal OvertimeHours { get; set; }
        [Column(TypeName = "Money")]
        public decimal ContractualEarnings { get; set; }
        [Column(TypeName = "Money")]
        public decimal OvertimeEarnings { get; set; }
        [Column(TypeName = "Money")]
        public decimal Tac { get; set; }
        [Column(TypeName = "Money")]
        public decimal NIC { get; set; }
        [Column(TypeName = "Money")]
        public decimal? UnionFee { get; set; }
        [Column(TypeName = "Money")]
        public Nullable<decimal> SLC { get; set; }
        [Column(TypeName = "Money")]
        public decimal TotalEarnings { get; set; }
        [Column(TypeName = "Money")]
        public decimal TotalDeduction { get; set; }
        [Column(TypeName ="Money")]
        public decimal NetPayment { get; set; }
    }
}
