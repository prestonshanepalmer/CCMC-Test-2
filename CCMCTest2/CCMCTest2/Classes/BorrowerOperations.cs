using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCMCTest2.Classes
{
    class BorrowerOperations
    {

        //public void InsertBorrower(Borrower borrower)
        //{
        //    string sqlQuery = String.Format("Insert into Borrowers () Values ();");

        //    SqlConnection connection = new SqlConnection();

        //    connection.Open();
        //    SqlCommand command = new SqlCommand(sqlQuery, connection);

        //    try
        //    {
        //        command.ExecuteNonQuery();
        //    }
        //    catch (SqlException e)
        //    {
                
        //    }
            
        //    command.Dispose();
        //    connection.Close();
        //    connection.Dispose();
            
        //}
        
        //public void GetBorrowers()
        //{
        //    List<Borrower> resultingBorrowers = new List<Borrower>();

        //    string sqlQuery = String.Format("select * from Borrowers");

        //    SqlConnection connection = new SqlConnection();
        //    connection.Open();

        //    SqlCommand command = new SqlCommand(sqlQuery, connection);

        //    SqlDataReader dataReader = command.ExecuteReader();

        //    Borrower borrowers = null;

        //    if (dataReader.Read())
        //    {
        //        borrowers = new Borrower();

        //        borrowers.Id = Convert.ToInt32(dataReader[""]);
        //        borrowers.Name = dataReader[""].ToString();
        //        borrowers.Gender = dataReader[""].ToString();
        //        borrowers.MonthlyIncome = Convert.ToDouble(dataReader[""]);

        //    }

        //}

        //public bool UpdateBorrower(Borrower borrower)
        //{
        //    bool result = false;

        //    string sqlQuery = String.Format("Update Borrower SET Id = '', Name = '', Gender ='', MonthlyIncome = '' Where Id = ;", borrower.Id, borrower.Name, borrower.Gender, borrower.MonthlyIncome);

        //    SqlConnection connection = new SqlConnection();
        //    connection.Open();

        //    SqlCommand command = new SqlCommand(sqlQuery, connection);

        //    int rowUpdated = command.ExecuteNonQuery();
        //    if (rowUpdated != 0)
        //    {
        //        result = true;
        //    }

        //    command.Dispose();
        //    connection.Close();
        //    command.Dispose();

        //    return result;

        //}
        
        //public bool DeleteBorrower(int id)
        //{
        //    bool result = false;

        //    string sqlQuery = String.Format("delete from Borrowers where Id = ", id);

        //    SqlConnection connection = new SqlConnection();
        //    connection.Open();

        //    SqlCommand command = new SqlCommand(sqlQuery, connection);

        //    int rowDeleted = command.ExecuteNonQuery();
        //    if (rowDeleted != 0)
        //    {
        //        result = true;
        //    }

        //    command.Dispose();
        //    connection.Close();
        //    connection.Dispose();

        //    return result;
        //}
    }
}
