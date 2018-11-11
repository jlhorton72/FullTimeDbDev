using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace U3ExamEmpSys
{
    /// <summary>
    /// This class will control the data access
    /// to our SQL table
    /// </summary>
    class DataAccess
    {
        #region --- Private Class Fields ---

        private static SqlConnection dbConn;        // connection object
        private static SqlCommand dbCmd;            // command object
        private static SqlDataReader dbReader;      // reader object
        private static FullTime aFullTime;
        private static string sConnection = 
            "Data Source=stusql-fa18cis151-rr.cimq4ah3jd04.us-east-2.rds.amazonaws.com,1433; " +
            "Initial Catalog=; User Id=; Password=";          // connection string
        private static string sql;                  // sql command string

        #endregion -- Privates --

        #region --- Public Static Methods ----
        public static void OpenDB()
        {
            try
            {
                dbConn = new SqlConnection(sConnection);
                dbConn.Open();
            } // end of try
            catch (System.Exception e)
            {
                Console.WriteLine(e);
                throw;
            } // end of catch
        } // end of OpenDB

        public static void CloseDB()
        {
            try
            {
                dbReader.Close();
            } // end of try
            catch (System.Exception e)
            {
                Console.Error.WriteLine(e);
                throw;
            } // end of catch
            finally
            {
                dbConn.Close();
            } // end of finally
        } // end of CloseDB

        public static ArrayList GetFullTimers()
        {
            OpenDB();
            dbReader = ReadFullTime();

            ArrayList fullEmp = new ArrayList();
            while (dbReader.Read())
            {
                aFullTime = new FullTime(
                    dbReader["EmployeeID"].ToString(),
                    dbReader["FirstName"].ToString(),
                    dbReader["LastName"].ToString(),
                    dbReader["DateHired"].ToString(),
                    dbReader["SSN"].ToString(),
                    dbReader["Emamil"].ToString(),
                    dbReader["PhoneNumber"].ToString(),
                    dbReader["TaxRate"].ToString(),
                    dbReader["Salary"].ToString(),
                    dbReader["NumberVacationDays"].ToString(),
                    dbReader["NumberSickDays"].ToString(),
                    dbReader["IsTaxEmept"].ToString(),
                    dbReader["IsInsured"].ToString());
                fullEmp.Add(aFullTime);
            } // end of while
            CloseDB();
            return fullEmp;

        } // end of getall

        public static SqlDataReader ReadFullTime()
        {
            try
            {
                // set up sql command
                sql = "SELECT * FROM EmployeeTable" +
                    "JOIN FullTime ON EmployeeTable.EmployeeID = FullTime.EmployeeID;" +
                    "ORDER BY LastName ASC, FirstName ASC;";
                dbCmd = new SqlCommand();
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbConn;

                // run sql commadn
                dbReader = dbCmd.ExecuteReader();
                //return dbReader;
            } // end of try
            catch(System.Exception e)
            {
                Console.Error.WriteLine(e);
            } // end of catch

            return dbReader;
        } // end of ReadFullTime

        public static void InsertFullTimer(FullTime insFull)
        {
            // add to employee table
            sql = "INSERT INTO EmployeeTable(EmployeeID, FirstName, LastName, DateHired, SSN, Email, PhoneNumber, TaxRate)" +
                "VALUES ('" +
                insFull.Id + "', '" + insFull.FirstName + "', '" +
                insFull.LastName + "', '" + insFull.Doh + "', '" +
                insFull.Ssn + "', '" + insFull.EMail + "', '" +
                insFull.PhoneNum + "', '" + insFull.TaxRate + "');";
            OpenDB();
            SqlCommand cmdInsert1 = new SqlCommand(sql, dbConn);
            ExecCommand(cmdInsert1);
            CloseDB();


            // adds to f/t table

            sql = "INSERT INTO FullTime(Salary, NumberVacationDays, NumberSickDays, IsTaxExempt, IsInsured, EmployeeID)" +
                "VALUES('" +
                insFull.Salary + "', '" + insFull.VacDays + "', '" +
                insFull.SickDays + "', '" + insFull.TaxExempt + "', '" +
                insFull.Insured + "', '" + insFull.Id + "');";
            OpenDB();
            SqlCommand cmdInsert = new SqlCommand(sql, dbConn);
            ExecCommand (cmdInsert);
            CloseDB();
        } // end of insert

        public static void UpdateEmployee(FullTime updEmp)
        {

            // to update the employee table
            sql = $"UPDATE EmployeeTable" +
                  $"SET FirstName = '{updEmp.FirstName}'," +
                  $"    LastName = '{updEmp.LastName}'," +
                  $"    DateHired = '{updEmp.Doh}'," +
                  $"    SSN = '{updEmp.Ssn}'," +
                  $"    Email = '{updEmp.EMail}'," +
                  $"    PhoneNumber = '{updEmp.PhoneNum}'," +
                  $"    TaxRate = '{updEmp.TaxRate}'" +
                $"WHERE EmployeeID = '{updEmp.Id}';";
            OpenDB();
            SqlCommand cmdUpdate = new SqlCommand(sql, dbConn);
            ExecCommand(cmdUpdate);
            CloseDB();

            // updates the fulltime table
            sql = $"UPDATE FullTime" +
                  $"SET Salary = '{updEmp.Salary}', " +
                  $"    NumberVacationDays = '{updEmp.VacDays}', " +
                  $"    NumberSickDays = '{updEmp.SickDays}', " +
                  $"    IsTaxExempt = '{updEmp.TaxExempt}'," +
                  $"IsInsured = '{updEmp.Insured}'," +
                $"WHERE EmployeeID = '{updEmp.Id}';";
            OpenDB();
            cmdUpdate = new SqlCommand(sql, dbConn);
            ExecCommand(cmdUpdate);
            CloseDB();
        } // end of UpdateEmployee


        public static void ExecCommand(SqlCommand theCmd)
        {
            try
            {
                theCmd.ExecuteNonQuery();
            } // end of try
            catch(Exception e)
            {
                Console.WriteLine(e);
                throw;
            } // end of catch
        } // end of ExecCommand

        #endregion -- methods --

    } // end of class
} // end of namespace
