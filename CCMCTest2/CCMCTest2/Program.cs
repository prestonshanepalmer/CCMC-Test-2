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
            //Monthly Payment, since it's generated from Percentage and TotalLoanAmount isn't used here, 
            //even it is is manually set, it resorts to the calculation instead. This will be set and shown
            //in the debugger.
            Loan loan1 = new Loan(1);
            loan1.LoanType = Enums.LoanTypeList.Fha;
            loan1.Percentage = 22.22;
            loan1.TotalLoanAmount = 145321.56;
            loan1.NumberOfMonths = 120;

            //If these two borrowers are set the either the same Id or Name, console.write will fire, an exception, however
            //should be fired instead... I'll revise, but this should satisfy the test criteria that the same borrower cannot
            //be added twice.
            Borrower borrower1 = new Borrower(4, "BB King");
            borrower1.Gender = Enums.GenderType.Male;
            borrower1.MonthlyIncome = 1.01;

            Borrower borrower2 = new Borrower(3, "Joel");
            borrower2.Gender = Enums.GenderType.Male;
            borrower2.MonthlyIncome = 1.01;

            loan1.AddBorrower(borrower1);
            loan1.AddBorrower(borrower2);

            //Checking for validity under certain conditions, there should be 4 conditions in this list.
            ValidateLoan validateLoan = new ValidateLoan();
            validateLoan.ValidateLoanProperties(loan1);

            
            //Code below is used to get borrowers from the mock repository.

            //BorrowersMockDbRespository borrowersListFromDb = new BorrowersMockDbRespository();
            //loan1.Borrowers = borrowersListFromDb.GetBorrowers();

            //Unit testing will ensue shortly.

        }
    }
}
