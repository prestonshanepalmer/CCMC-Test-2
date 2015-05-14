using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCMCTest2.Classes
{
    class Loan
    {
        public int Id { get; set; }

        private string _eLoanType = string.Empty; 
        public string LoanType
        {
            get { return _eLoanType; }
            set
            {
                if (value != null)
                {
                    _eLoanType = value;
                }
                else
                {
                    _eLoanType = string.Empty;
                }
            }
        }

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

        public void CreateBorrower(int id, string name, string gender, double monthlyincome)
        {

            Borrower newBorrower = new Borrower();
            newBorrower.Id = id;
            newBorrower.Name = name;
            newBorrower.Gender = gender;
            newBorrower.MonthlyIncome = monthlyincome;

            Borrowers.Add(newBorrower);

        }

    }
}
