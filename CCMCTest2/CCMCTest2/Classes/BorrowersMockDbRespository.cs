using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CCMCTest2.Classes
{
    class BorrowersMockDbRespository
    {
        //Not quite finished with these and not sure to what extend you want these stubbed. Should for example, UpdateBorrower
        //function to update a borrower to new info... I can do that. But, InsertBorrower directly refers to inserting into the database,
        //so what would I do for that? If it was mock functional, then it would work as a simple addition to the list of Borrowers and
        //that would be different from the expected Insert functionality.... would it make sense to do that? So I simply set the methods
        //that would be there for now. GetBorrowers is an exception because it can easily be set with mock data. As well, I'll flesh out
        //Update, and Delete... but again, these mock functions are different than updating and deleting from a database... thoughts?
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




