using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCMCTest2.Classes
{
    class ValidateLoan
    {
        public List<string> InvalidListMessages = new List<string>(); 

        public List<string> ValidateLoanProperties(Loan loan)
        {

            if (loan.Id == 1)
            {
                InvalidListMessages.Add("This Loan ID is already used.");  
            }

            if (loan.LoanType != Enums.LoanTypeList.Fha)
            {
                InvalidListMessages.Add("Loan type error message.");
            }

            if (loan.Percentage != null && loan.Percentage > 0 && loan.Percentage < 100)
            {
                InvalidListMessages.Add("Loan percentage out of range.");
            }

            if (loan.TotalLoanAmount != null && loan.TotalLoanAmount > 0)
            {
                InvalidListMessages.Add("Total loan amount 0 or below.");
            }

            if (loan.NumberOfMonths != null && loan.NumberOfMonths > 120)
            {
                InvalidListMessages.Add("Number of months error message.");
            }

            if (loan.MonthlyPayment != null && loan.MonthlyPayment < 2000.00)
            {
                InvalidListMessages.Add("Monthly payment amount error message.");
            }

            return InvalidListMessages;
        }
        
    }
}
