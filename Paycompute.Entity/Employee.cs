using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paycompute.Entity
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string EmployeeNo { get; set; }
        [Required, MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string MiddleName { get; set; }
        [Required,MaxLength(50)]
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string ImageURL { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DateJoined { get; set; } 
        public string Phone { get; set; }   
        public string Desgination { get; set; }
        public string Email { get; set; }
        [Required, MaxLength(50)]
        public string NationalInsuranceNo { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public StudentLoan StudentLoan { get; set; }
        public UnionMember UnionMember { get; set; }
        [Required, MaxLength(150)]
        public string Address { get; set; }
        [Required, MaxLength(50)]
        public string City { get; set; }
        [Required, MaxLength(50)]
        public string PostCode { get; set; }
        public IEnumerable<PaymentRecord> PaymentRecords { get; set; }
    }
}
