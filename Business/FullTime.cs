using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Name:       James Horton
/// Date:       11/6/18           
/// Purpose:    Create a new Employee System (11EmployeePart2)
/// File:       _11EmployeePart2
/// </summary>

namespace U3ExamEmpSys
{
    class FullTime : Employee
    {
        #region Class Fields

        private decimal salary;
        private double vacDays;
        private double sickDays;
        private bool taxExempt;
        private bool insured;

        #endregion Class Fields

        #region Public Properties

        public decimal Salary { get => salary; set => salary = value; }
        public double VacDays { get => vacDays; set => vacDays = value; }
        public double SickDays { get => sickDays; set => sickDays = value; }
        public bool TaxExempt { get => taxExempt; set => taxExempt = value; }
        public bool Insured { get => insured; set => insured = value; }

        #endregion Public Properties

        #region Constructors
        /// <summary>
        /// No Arg Constructor
        /// </summary>
        public FullTime()
        {

        } // end of FullTime constructor no args

        /// <summary>
        /// Full Constructor
        /// </summary>
        public FullTime(decimal salaryAmt, double vDays, double sDays, bool taxEx, bool insurance)
        {
            salary = salaryAmt;
            vacDays = vDays;
            sickDays = sDays;
            taxExempt = taxEx;
            insured = insurance;
        } // end of FullTime constructor all args

        public FullTime(string idNum, string fName, string lName, string hireDate, string social, string mail, string phone, string tRate, string salaryAmt, string vDays, string sDays, string taxEx, string insurance)
        {
            //Employee(idNum, fName, lName, hireDate, social, mail, phone);
             // changed from private to protected to get this accomplished


            this.id = Convert.ToInt32(idNum);
            this.firstName = fName;
            this.lastName = lName;
            this.doh = DateTime.Parse(hireDate);
            this.ssn = social;
            this.eMail = mail;
            this.phoneNum = phone;
            this.taxRate = decimal.Parse(tRate);


            salary = decimal.Parse(salaryAmt);
            vacDays = Convert.ToDouble(vDays);
            sickDays = Convert.ToDouble(sDays);
            taxExempt = Boolean.Parse(taxEx);
            insured = Boolean.Parse(insurance);
        } // end of Fulltime with args for employee

        /// <summary>
        /// Added by refactoring to solve an error
        /// with GetAllFullTime() in DataAdapter Class
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <param name="v3"></param>
        /// <param name="v4"></param>
        public FullTime(string v1, string v2, string v3, string v4, string v5)
        {
        } // end of FullTime constructor

        #endregion Constructors

        #region Methods
        /// <summary>
        /// Overrides ToString 
        /// and
        /// Returns First and Last names from Employee Class Inheritance
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return FirstName + " " + LastName;
        } // end of override ToString()

        // method to get all fulltime rows

        public static ArrayList GetFullTime()
        {
            return DataAccess.GetFullTimers();
        } // end of GetFullTimers



        /// <summary>
        /// CalcTaxes method that overrides the virtual 
        /// method declared in the base class
        /// </summary>
        /// <returns></returns>
        public override decimal CalcTaxes()
        {
            // should reflect the istaxExempt bool and then
            // figure taxes based on taxrate
            decimal x = 0.5M;
            return x;
        } // end of override calculateTaxes

        /// <summary>
        /// CalcTotalEarnings method that overrides 
        /// the virtual method declared in the base class
        /// </summary>
        /// <returns></returns>
        public override decimal CalcTotalEarnings()
        {
            // should take the salary or wages and subtract 
            // the insured cost if applicable and taxes
            decimal y = 22.55M;
            return y;
        } // end of override calcTotalEarnings

        public void InsertFullTimeEmp()
        {
            DataAccess.InsertFullTimer(this);
        } // end of insert

        public void UpdateEmployee()
        {
            DataAccess.UpdateEmployee(this);
        } // end of insertEmployee

        #endregion Method

    } // end of class FullTime
} // end of namespace
