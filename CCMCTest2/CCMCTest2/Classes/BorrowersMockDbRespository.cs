using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CCMCTest2.Classes
{
    class BorrowersMockDbRespository
    {
        public int InsertBorrower(Borrower borrower)
        {
            int borrowerRowInserted = new int();

            return borrowerRowInserted;
        }

        public List<Borrower> GetBorrowers()
        {
            List<Borrower> resultingBorrowers = new List<Borrower>();

            Borrower borrower1 = new Borrower(1, "Jane Doe");
            borrower1.Gender = Enums.GenderType.Female;
            borrower1.MonthlyIncome = 1000.50;


            Borrower borrower2 = new Borrower(2, "Barry Doe");
            borrower2.Gender = Enums.GenderType.Male;
            borrower2.MonthlyIncome = 2001.00;


            Borrower borrower3 = new Borrower(3, "Jimmy John");
            borrower3.Gender = Enums.GenderType.Male;
            borrower3.MonthlyIncome = 750.60;

            
            resultingBorrowers.Add(borrower1);
            resultingBorrowers.Add(borrower2);
            resultingBorrowers.Add(borrower3);

            return resultingBorrowers;

        }

        public int UpdateBorrower(Borrower borrower)
        {
            int borrowerRowUpdated = new int();

            return borrowerRowUpdated;
        }

        public int DeleteBorrower(int id)
        {
            int borrowerRowsDeleted = new int();

            return borrowerRowsDeleted;
        }
    }
}




