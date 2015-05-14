using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCMCTest2.Classes
{
    class Loan
    {
        public Loan(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

        public enum LoanTypeList
        {
            NotSpecified,
            Conventional,
            Fha,
            Arm
        }

        public LoanTypeList LoanType { get; set; }

        public double? Percentage { get; set; }

        public double? TotalLoanAmount { get; set; }

        public int? NumberOfMonths { get; set; }

        public double? MonthlyPayment { get; set; }
        
        public void GetMonthlyPayments()
        {
            double? monthlyPayment = new double();

            if (TotalLoanAmount != null || NumberOfMonths != null)
            {
                monthlyPayment = TotalLoanAmount/NumberOfMonths;
            }
            else
            {
                monthlyPayment = null;
            }

            MonthlyPayment = monthlyPayment;
        }

        public List<Borrower> Borrowers = new List<Borrower>(); 

    }
}
