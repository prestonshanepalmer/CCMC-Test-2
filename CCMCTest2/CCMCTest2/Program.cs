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
            loan1.LoanType = Enums.LoanTypeList.Fha;
            loan1.Percentage = 56.33;
            loan1.TotalLoanAmount = 145321.56;
            loan1.NumberOfMonths = 120;

            Borrower borrower1 = new Borrower(4, "BB King");
            borrower1.Gender = Enums.GenderType.Male;
            borrower1.MonthlyIncome = 1.01;

            loan1.AddBorrower(borrower1);

            

            //BorrowersMockDbRespository borrowersListFromDb = new BorrowersMockDbRespository();

            //loan1.Borrowers = borrowersListFromDb.GetBorrowers();

        }
    }
}
