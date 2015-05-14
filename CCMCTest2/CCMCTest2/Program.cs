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

            BorrowersMockDbRespository borrowersListFromDb = new BorrowersMockDbRespository();

            loan1.Borrowers = borrowersListFromDb.GetBorrowers();

        }
    }
}
