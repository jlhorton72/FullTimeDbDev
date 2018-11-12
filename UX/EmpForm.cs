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
            EnableDisable(false);
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
            btnDelete.Visible = false;
            btnDelete.Enabled = false;
            lblMessage.Text = "You are ready to add an employee";
            EnableDisable(false);
            ClearText();
            selected = -1;
            EnableDisable(true);
            txtBxEmpID.Focus();
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
                //if (txtBxTaxRate.Text = "")
                //{
                //    string taxRate = "0.0";
                //    aFullTime.TaxRate = decimal.Parse(taxRate);
                //} // end of if
                aFullTime.TaxRate = decimal.Parse(txtBxTaxRate.Text);
                aFullTime.Salary = decimal.Parse(txtBxSal.Text);
                aFullTime.VacDays = Convert.ToDouble(txtBxVacDay.Text);
                aFullTime.SickDays = Convert.ToDouble(txtBxSick.Text);
                if (txtBxTax.Text == "Y")
                {
                    aFullTime.TaxExempt = true;
                } // end of true
                else
                {
                    aFullTime.TaxExempt = false;
                } // end of false
                //aFullTime.TaxExempt = Boolean.Parse(txtBxTax.Text);
                if (txtBxIns.Text == "Y")
                {
                    aFullTime.Insured = true;
                } // end of true
                else
                {
                    aFullTime.Insured = false;
                } // end of false
                //aFullTime.Insured = Boolean.Parse(txtBxIns.Text);
                aFullTime.UpdateEmployee();
                lblMessage.Text = "Employee Updated";
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
            btnDelete.Enabled = false;
            btnDelete.Visible = false;
            selected = lstBxFullTime.SelectedIndex;
            LoadText();
            lblMessage.Text = "You are viewing highlighted employee's information";
        } // end of lstbxFullTimeSelectedIndexChanged

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "You are about to update this employee's information";
            EnableDisable(true);
            txtBxFName.Focus();
            LoadText();
        }// end of event

        private void LoadText()
        {
            //EnableDisable(false);
            btnDelete.Visible = false;
            btnDelete.Enabled = false;
            try
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
                txtBxTaxRate.Text = aFullTime.TaxRate.ToString();
                txtBxSal.Text = aFullTime.Salary.ToString();
                txtBxVacDay.Text = aFullTime.VacDays.ToString();
                txtBxSick.Text = aFullTime.SickDays.ToString();

                if (aFullTime.TaxExempt.ToString() == "True")
                {
                    txtBxTax.Text = "Y";
                } // end of true
                else
                {
                    txtBxTax.Text = "N";
                } // end of false
                  //txtBxTax.Text = aFullTime.TaxExempt.ToString();
                if (aFullTime.Insured.ToString() == "True")
                {
                    txtBxIns.Text = "Y";
                } // end of true
                else
                {
                    txtBxIns.Text = "N";
                } // end of false
            } // end of try
            catch(Exception e)
            {
                lblMessage.Text = "Must have an employee selected";
            } // end of catch
            //txtBxIns.Text = aFullTime.Insured.ToString();
        } // end of loadText

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            // figure out which one is selected
            lblMessage.Text = "Are you sure you want to delete employee: " + txtBxFName.Text + " " + txtBxLName.Text;
            // ask for verify which one to delete
            btnOK.Enabled = false;
            btnDelete.Visible = true;
            btnDelete.Enabled = true;
            // delete with btnOK click ??
        } // end of delete

        private void btnDelete_Click(object sender, EventArgs e)
        {
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
            if (txtBxTax.Text == "Y")
            {
                aFullTime.TaxExempt = true;
            } // end of true
            else
            {
                aFullTime.TaxExempt = false;
            } // end of false
            if (txtBxIns.Text == "Y")
            {
                aFullTime.Insured = true;
            } // end of true
            else
            {
                aFullTime.Insured = false;
            } // end of false
            aFullTime.DeleteEmp();
            lblMessage.Text = "Delete Completed";
            btnDelete.Enabled = false;
            btnDelete.Visible = false;
            ClearText();
            EnableDisable(false);


        } // end of delete


    } // end of form class
} // end of namespace
