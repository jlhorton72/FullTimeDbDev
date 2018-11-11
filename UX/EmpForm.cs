using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U3ExamEmpSys
{
    public partial class EmpForm : Form
    {
        // declare class level fields
        //private Employee anEmployee;
        private FullTime aFullTime;
        private int selected = -1;       // item selected


        public EmpForm()
        {
            InitializeComponent();
        } // end of EmpForm

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadItems();
            lblMessage.Text = " FullTimers Loaded";

        } // end of btnLoad_Click

        private void LoadItems()
        {
            lstBxFullTime.Items.Clear();

            ArrayList ar = FullTime.GetFullTime();
            // foreaach f/t , add to listbox
            foreach(FullTime fullTimer in ar)
            {
                lstBxFullTime.Items.Add(fullTimer);
            } // end of foreach
        } // end of LoadItems

        public void EnableDisable(bool value)
        {
            txtBxEmpID.Enabled = value;
            txtBxFName.Enabled = value;
            txtBxLName.Enabled = value;
            txtBxDOH.Enabled = value;
            txtBxSSN.Enabled = value;
            txtBxMail.Enabled = value;
            txtBxPhNum.Enabled = value;
            txtBxTaxRate.Enabled = value;
            txtBxSal.Enabled = value;
            txtBxVacDay.Enabled = value;
            txtBxSick.Enabled = value;
            txtBxTax.Enabled = value;
            txtBxIns.Enabled = value;
            btnOK.Enabled = value;
        } // end of EnabeDisable

        public void ClearText()
        {
            txtBxEmpID.Text = "";
            txtBxFName.Text = "";
            txtBxLName.Text = "";
            txtBxDOH.Text = "";
            txtBxSSN.Text = "";
            txtBxMail.Text = "";
            txtBxPhNum.Text = "";
            txtBxTaxRate.Text = "";
            txtBxSal.Text = "";
            txtBxVacDay.Text = "";
            txtBxSick.Text = "";
            txtBxTax.Text = "";
            txtBxIns.Text = "";
        } // end of clearText

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            selected = -1;
            EnableDisable(true);
            txtBxFName.Focus();
        } // end of add

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (selected == -1)
            {
                //anEmployee = new Employee(txtBxEmpID.Text, txtBxFName.Text, txtBxLName.Text, txtBxDOH.Text, txtBxSSN.Text, txtBxMail.Text, txtBxPhNum.Text, txtBxTaxRate.Text);

                aFullTime = new FullTime(txtBxEmpID.Text, txtBxFName.Text,
                        txtBxLName.Text, txtBxDOH.Text, txtBxSSN.Text, 
                        txtBxMail.Text, txtBxPhNum.Text, txtBxTaxRate.Text,
                        txtBxSal.Text, txtBxVacDay.Text, txtBxSick.Text,
                        txtBxTax.Text, txtBxIns.Text);
                aFullTime.InsertFullTimeEmp();
                lblMessage.Text = "FullTimer Added";

                LoadItems();
                EnableDisable(false);
                ClearText();

            }  // end of if
            else
            {
                //aFullTime = (FullTime)lstBxFullTime.Items[selected];
                aFullTime.FirstName = txtBxFName.Text;
                aFullTime.LastName = txtBxLName.Text;
                aFullTime.Doh = DateTime.Parse(txtBxDOH.Text);
                aFullTime.Ssn = txtBxSSN.Text;
                aFullTime.EMail = txtBxMail.Text;
                aFullTime.PhoneNum = txtBxPhNum.Text;
                aFullTime.TaxRate = decimal.Parse(txtBxTaxRate.Text);
                aFullTime.Salary = decimal.Parse(txtBxSal.Text);
                aFullTime.VacDays = Convert.ToDouble(txtBxVacDay.Text);
                aFullTime.SickDays = Convert.ToDouble(txtBxSick.Text);
                aFullTime.TaxExempt = Boolean.Parse(txtBxTax.Text);
                aFullTime.Insured = Boolean.Parse(txtBxIns.Text);
                aFullTime.UpdateEmployee();
                lblMessage.Text = "Employee Update";
                LoadItems();
                EnableDisable(false);
                ClearText();
            } // end of else

        } // end of btnOK-Click

        private void EmpForm_Load(object sender, EventArgs e)
        {
            EnableDisable(false);
        }

        private void lstBxFullTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = lstBxFullTime.SelectedIndex;
        } // end of lstbxFullTimeSelectedIndexChanged

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            EnableDisable(true);
            txtBxEmpID.Focus();
            LoadText();
        }// end of event

        private void LoadText()
        {
            aFullTime = (FullTime)lstBxFullTime.Items[selected];
            txtBxEmpID.Text = aFullTime.Id.ToString();
            txtBxEmpID.Enabled = false;
            txtBxFName.Text = aFullTime.FirstName;
            txtBxLName.Text = aFullTime.LastName;
            txtBxDOH.Text = aFullTime.Doh.ToString();
            txtBxSSN.Text = aFullTime.Ssn;
            txtBxMail.Text = aFullTime.EMail;
            txtBxPhNum.Text = aFullTime.PhoneNum;
            txtBxSal.Text = aFullTime.Salary.ToString();
            txtBxVacDay.Text = aFullTime.VacDays.ToString();
            txtBxSick.Text = aFullTime.SickDays.ToString();
            txtBxTax.Text = aFullTime.TaxExempt.ToString();
            txtBxIns.Text = aFullTime.Insured.ToString();
        } // end of loadText

    } // end of form class
} // end of namespace
