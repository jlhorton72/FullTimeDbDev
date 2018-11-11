namespace U3ExamEmpSys
{
    partial class EmpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpForm));
            this.lstBxFullTime = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblSal = new System.Windows.Forms.Label();
            this.lblVac = new System.Windows.Forms.Label();
            this.lblSick = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblIns = new System.Windows.Forms.Label();
            this.txtBxSal = new System.Windows.Forms.TextBox();
            this.txtBxVacDay = new System.Windows.Forms.TextBox();
            this.txtBxSick = new System.Windows.Forms.TextBox();
            this.txtBxTax = new System.Windows.Forms.TextBox();
            this.txtBxIns = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.txtBxSSN = new System.Windows.Forms.TextBox();
            this.txtBxDOH = new System.Windows.Forms.TextBox();
            this.txtBxLName = new System.Windows.Forms.TextBox();
            this.txtBxFName = new System.Windows.Forms.TextBox();
            this.txtBxEmpID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBxTaxRate = new System.Windows.Forms.TextBox();
            this.txtBxPhNum = new System.Windows.Forms.TextBox();
            this.txtBxMail = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBxFullTime
            // 
            this.lstBxFullTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lstBxFullTime.FormattingEnabled = true;
            this.lstBxFullTime.ItemHeight = 22;
            this.lstBxFullTime.Location = new System.Drawing.Point(90, 88);
            this.lstBxFullTime.Name = "lstBxFullTime";
            this.lstBxFullTime.Size = new System.Drawing.Size(236, 202);
            this.lstBxFullTime.TabIndex = 0;
            this.lstBxFullTime.SelectedIndexChanged += new System.EventHandler(this.lstBxFullTime_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "FullTime EE\'s";
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLoad.Location = new System.Drawing.Point(156, 347);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(108, 38);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load EE\'s";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Location = new System.Drawing.Point(965, 96);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(62, 22);
            this.lblSal.TabIndex = 3;
            this.lblSal.Text = "Salary";
            // 
            // lblVac
            // 
            this.lblVac.AutoSize = true;
            this.lblVac.Location = new System.Drawing.Point(897, 137);
            this.lblVac.Name = "lblVac";
            this.lblVac.Size = new System.Drawing.Size(130, 22);
            this.lblVac.TabIndex = 4;
            this.lblVac.Text = "Vacation Days";
            // 
            // lblSick
            // 
            this.lblSick.AutoSize = true;
            this.lblSick.Location = new System.Drawing.Point(933, 178);
            this.lblSick.Name = "lblSick";
            this.lblSick.Size = new System.Drawing.Size(94, 22);
            this.lblSick.TabIndex = 5;
            this.lblSick.Text = "Sick Days";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(918, 220);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(109, 22);
            this.lblTax.TabIndex = 6;
            this.lblTax.Text = "Tax Exempt";
            // 
            // lblIns
            // 
            this.lblIns.AutoSize = true;
            this.lblIns.Location = new System.Drawing.Point(953, 264);
            this.lblIns.Name = "lblIns";
            this.lblIns.Size = new System.Drawing.Size(74, 22);
            this.lblIns.TabIndex = 7;
            this.lblIns.Text = "Insured";
            // 
            // txtBxSal
            // 
            this.txtBxSal.Location = new System.Drawing.Point(1068, 93);
            this.txtBxSal.Name = "txtBxSal";
            this.txtBxSal.Size = new System.Drawing.Size(191, 29);
            this.txtBxSal.TabIndex = 8;
            // 
            // txtBxVacDay
            // 
            this.txtBxVacDay.Location = new System.Drawing.Point(1068, 134);
            this.txtBxVacDay.Name = "txtBxVacDay";
            this.txtBxVacDay.Size = new System.Drawing.Size(191, 29);
            this.txtBxVacDay.TabIndex = 9;
            // 
            // txtBxSick
            // 
            this.txtBxSick.Location = new System.Drawing.Point(1068, 175);
            this.txtBxSick.Name = "txtBxSick";
            this.txtBxSick.Size = new System.Drawing.Size(191, 29);
            this.txtBxSick.TabIndex = 10;
            // 
            // txtBxTax
            // 
            this.txtBxTax.Location = new System.Drawing.Point(1068, 217);
            this.txtBxTax.Name = "txtBxTax";
            this.txtBxTax.Size = new System.Drawing.Size(191, 29);
            this.txtBxTax.TabIndex = 11;
            // 
            // txtBxIns
            // 
            this.txtBxIns.Location = new System.Drawing.Point(1068, 261);
            this.txtBxIns.Name = "txtBxIns";
            this.txtBxIns.Size = new System.Drawing.Size(191, 29);
            this.txtBxIns.TabIndex = 12;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(1111, 347);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 44);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(37, 472);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(436, 22);
            this.lblMessage.TabIndex = 14;
            this.lblMessage.Text = "Welcome to the FullTime EE management System";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd,
            this.toolStripButtonUpdate,
            this.toolStripButtonDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1392, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdd.Image")));
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAdd.Text = "toolStripButton1";
            this.toolStripButtonAdd.ToolTipText = "Add Employee";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonUpdate
            // 
            this.toolStripButtonUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpdate.Image")));
            this.toolStripButtonUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdate.Name = "toolStripButtonUpdate";
            this.toolStripButtonUpdate.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUpdate.Text = "toolStripButton2";
            this.toolStripButtonUpdate.ToolTipText = "Update Employee";
            this.toolStripButtonUpdate.Click += new System.EventHandler(this.toolStripButtonUpdate_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDelete.Text = "toolStripButton3";
            this.toolStripButtonDelete.ToolTipText = "Delete Employee";
            // 
            // txtBxSSN
            // 
            this.txtBxSSN.Location = new System.Drawing.Point(601, 261);
            this.txtBxSSN.Name = "txtBxSSN";
            this.txtBxSSN.Size = new System.Drawing.Size(191, 29);
            this.txtBxSSN.TabIndex = 25;
            // 
            // txtBxDOH
            // 
            this.txtBxDOH.Location = new System.Drawing.Point(601, 217);
            this.txtBxDOH.Name = "txtBxDOH";
            this.txtBxDOH.Size = new System.Drawing.Size(191, 29);
            this.txtBxDOH.TabIndex = 24;
            // 
            // txtBxLName
            // 
            this.txtBxLName.Location = new System.Drawing.Point(601, 175);
            this.txtBxLName.Name = "txtBxLName";
            this.txtBxLName.Size = new System.Drawing.Size(191, 29);
            this.txtBxLName.TabIndex = 23;
            // 
            // txtBxFName
            // 
            this.txtBxFName.Location = new System.Drawing.Point(601, 134);
            this.txtBxFName.Name = "txtBxFName";
            this.txtBxFName.Size = new System.Drawing.Size(191, 29);
            this.txtBxFName.TabIndex = 22;
            // 
            // txtBxEmpID
            // 
            this.txtBxEmpID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtBxEmpID.Location = new System.Drawing.Point(601, 93);
            this.txtBxEmpID.Name = "txtBxEmpID";
            this.txtBxEmpID.Size = new System.Drawing.Size(191, 29);
            this.txtBxEmpID.TabIndex = 21;
            this.txtBxEmpID.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "SSN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Date of Hire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "EmployeeID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(475, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 22);
            this.label7.TabIndex = 26;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(395, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 22);
            this.label8.TabIndex = 27;
            this.label8.Text = "Phone Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(448, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 22);
            this.label9.TabIndex = 28;
            this.label9.Text = "Tax Rate";
            // 
            // txtBxTaxRate
            // 
            this.txtBxTaxRate.Location = new System.Drawing.Point(601, 405);
            this.txtBxTaxRate.Name = "txtBxTaxRate";
            this.txtBxTaxRate.Size = new System.Drawing.Size(191, 29);
            this.txtBxTaxRate.TabIndex = 29;
            // 
            // txtBxPhNum
            // 
            this.txtBxPhNum.Location = new System.Drawing.Point(601, 355);
            this.txtBxPhNum.Name = "txtBxPhNum";
            this.txtBxPhNum.Size = new System.Drawing.Size(191, 29);
            this.txtBxPhNum.TabIndex = 30;
            // 
            // txtBxMail
            // 
            this.txtBxMail.Location = new System.Drawing.Point(601, 312);
            this.txtBxMail.Name = "txtBxMail";
            this.txtBxMail.Size = new System.Drawing.Size(191, 29);
            this.txtBxMail.TabIndex = 31;
            // 
            // EmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1392, 549);
            this.Controls.Add(this.txtBxMail);
            this.Controls.Add(this.txtBxPhNum);
            this.Controls.Add(this.txtBxTaxRate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBxSSN);
            this.Controls.Add(this.txtBxDOH);
            this.Controls.Add(this.txtBxLName);
            this.Controls.Add(this.txtBxFName);
            this.Controls.Add(this.txtBxEmpID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtBxIns);
            this.Controls.Add(this.txtBxTax);
            this.Controls.Add(this.txtBxSick);
            this.Controls.Add(this.txtBxVacDay);
            this.Controls.Add(this.txtBxSal);
            this.Controls.Add(this.lblIns);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSick);
            this.Controls.Add(this.lblVac);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBxFullTime);
            this.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "EmpForm";
            this.Text = "FullTime Management";
            this.Load += new System.EventHandler(this.EmpForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxFullTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.Label lblVac;
        private System.Windows.Forms.Label lblSick;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblIns;
        private System.Windows.Forms.TextBox txtBxSal;
        private System.Windows.Forms.TextBox txtBxVacDay;
        private System.Windows.Forms.TextBox txtBxSick;
        private System.Windows.Forms.TextBox txtBxTax;
        private System.Windows.Forms.TextBox txtBxIns;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdate;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.TextBox txtBxSSN;
        private System.Windows.Forms.TextBox txtBxDOH;
        private System.Windows.Forms.TextBox txtBxLName;
        private System.Windows.Forms.TextBox txtBxFName;
        private System.Windows.Forms.TextBox txtBxEmpID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBxTaxRate;
        private System.Windows.Forms.TextBox txtBxPhNum;
        private System.Windows.Forms.TextBox txtBxMail;
    }
}

