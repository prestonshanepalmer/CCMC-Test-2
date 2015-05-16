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


        public int Id
        {
            get; private set;
        }

        public Enums.LoanTypeList LoanType { get; set; }

        public double? Percentage { get; set; }

        public double? TotalLoanAmount { get; set; }

        public int? NumberOfMonths { get; set; }

        private double? _monthlyPayment = new double();
        public double? MonthlyPayment
        {
            get
            {
                return GetMonthlyPayments();
            }
            set
            {
                _monthlyPayment = GetMonthlyPayments();
                value = _monthlyPayment;
            }
            
        }
        
        private double? GetMonthlyPayments()
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

            return monthlyPayment;
        }

        
        private List<Borrower> Borrowers = new List<Borrower>();
        
        public void AddBorrower(Borrower borrower)
        {
            Borrowers.Add(borrower);
        }

    }
}
