using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCMCTest2.Classes;

namespace CCMCTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            Loan loan1 = new Loan(1);
            //loan1.LoanType.Fha;
            loan1.Percentage = 56.33;
            loan1.TotalLoanAmount = 145321.56;
            loan1.NumberOfMonths = 120;
            loan1.GetMonthlyPayments();
            loan1.AddBorrower(1, "Homie Johnson", Borrower.GenderType.Male, 432.50);
            loan1.AddBorrower(2, "Shane Palmer", Borrower.GenderType.Male, 9080.22);
            loan1.AddBorrower(2, "Christen Skinner", Borrower.GenderType.Female, 10000);
            
        }
    }
}
