using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3ExamEmpSys
{
    // ** Name:         James Horton
    // ** Date:         10/23/2018
    // ** Assignment:   Employee Management System
    // ** File:         9EmployeeMgmt1


    abstract class Employee
    {
        #region --- Private Fields ---
        protected int id;
        protected string firstName;
        protected string lastName;
        protected DateTime doh;
        protected string ssn;
        protected string eMail;
        protected string phoneNum;
        protected decimal taxRate;
        #endregion -- privates --

        #region --- Public Properties ---
        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime Doh { get => doh; set => doh = value; }
        public string Ssn { get => ssn; set => ssn = value; }
        public string EMail { get => eMail; set => eMail = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public decimal TaxRate { get => taxRate; set => taxRate = value; }
        #endregion -- public props --

        #region  --- Constructors ---

        public Employee()
        {

        } // end of no arg

        /// <summary>
        /// should construct each employee
        /// </summary>
        /// <param name="idNum"></param>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="hireDate"></param>
        /// <param name="social"></param>
        /// <param name="mail"></param>
        /// <param name="phone"></param>
        /// <param name="tRate"></param>
        public Employee(int idNum, string fName, string lName, DateTime hireDate, string social, string mail, string phone, decimal tRate)
        {
            this.id = idNum;
            this.firstName = fName;
            this.lastName = lName;
            this.doh = hireDate;
            this.ssn = social;
            this.eMail = mail;
            this.phoneNum = phone;
            this.taxRate = tRate;
        } // end of Employee constructor

        #endregion -- end constructs --

        /// <summary>
        ///  generic print/display of the employee
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Employee: {lastName}, {fisrtName}\n" +
                "Date of Hire: {doh}\n" + "SSN: {ssn}\n" +
                "EMail: {eMail}\n" + "Phone #: {phoneNum}\n" +
                "Emp Tax Rate: {taxRate}\n";
        } // end of ToString override

        /// <summary>
        ///  to be defined by the children
        /// </summary>
        /// <returns></returns>
        abstract public decimal CalcTaxes();

        /// <summary>
        /// to be defined by the children
        /// </summary>
        /// <returns></returns>
        abstract public decimal CalcTotalEarnings();


    } // end of class Employee
} // end of namespace
