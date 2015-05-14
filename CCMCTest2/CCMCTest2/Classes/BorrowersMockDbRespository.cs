using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCMCTest2.Classes
{
    class BorrowersMockDbRespository
    {
        public void InsertBorrower(Borrower borrower)
        {


        }

        //public int AddBorrower(Borrower borrower)
        //{
        //    Borrower borrower1 = new Borrower(1, "Shane Palmer");

        //    borrower1.MonthlyIncome = 212.50;
        //    borrower1.Gender = Borrower.GenderType.Male;


        //}

        //public void AddBorrower(int id, string name, Borrower.GenderType gender, double monthlyincome)
        //{

        //    Borrower newBorrower = new Borrower(id, name);

        //    newBorrower. = gender;
            //    newBorrower.MonthlyIncome = monthlyincome;

        //    Borrowers.Add(newBorrower);

        //}

        public List<Borrower> GetBorrowers()
        {
            List<Borrower> resultingBorrowers = new List<Borrower>();

            Borrower borrower1 = new Borrower(1, "Jane Doe");
            borrower1.Gender = Borrower.GenderType.Female;
            borrower1.MonthlyIncome = 1000.50;


            Borrower borrower2 = new Borrower(2, "Barry Doe");
            borrower2.Gender = Borrower.GenderType.Male;
            borrower2.MonthlyIncome = 2001.00;


            Borrower borrower3 = new Borrower(3, "Jimmy John");
            borrower3.Gender = Borrower.GenderType.Male;
            borrower3.MonthlyIncome = 750.60;

            
            resultingBorrowers.Add(borrower1);
            resultingBorrowers.Add(borrower2);
            resultingBorrowers.Add(borrower3);

            return resultingBorrowers;

        }

        //public int UpdateBorrower(Borrower borrower)
        //{

            
        //}

        //public int DeleteBorrower(int id)
        //{

        //}
    }
}




