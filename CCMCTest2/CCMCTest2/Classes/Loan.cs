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
            //Used Exists to check whether the borrower Name and Id are in the Borrowers list. 
            //This is in lieu of using Dictionary, which had key, value pairs and seemed a little more complicated.
            //I can explain that... Also, not sure if we should check for both Id AND Name, I'm assuming we need to guard against
            //the same Id being used twice, and I figure that a name could be entered differently for the same person
            //i.e: "Doug Nettles" & "Doug E. Nettles" or "Doug Ethan Nettles", so I suspect the name checking alone could be erroneous.
            //How would you handle this? Regular expression? I would think that might he a problem too "Doug E. Nettles" and "Doug Ethan Nettles"
            //could actually be different people and I imagine we wouldn't run into "Doug, Nettles Ethan" amd "Doug Ethan Nettles"
            //because we can handle the way it's formatted from the front end.

            bool checkName = Borrowers.Exists(element => element.Name == borrower.Name);
            bool checkId = Borrowers.Exists(element => element.Id == borrower.Id);

            if (!checkName && !checkId)
            {
                Borrowers.Add(borrower);
            }
            else
            {
                //A check of mine. I'm guessing I need to throw an exception here... I'll revise.
                Console.Write("borrower added already");
                Console.Read();
            }
            
        }

    }
}
