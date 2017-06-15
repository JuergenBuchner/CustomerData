using System;
using System.Windows.Forms;

namespace CustomerData_SlowCookers
{
    partial class formAdd_Edit
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtBoxEMail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblAddMoney = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtBoxBalance = new System.Windows.Forms.NumericUpDown();
            this.txtBoxAddMoney = new System.Windows.Forms.NumericUpDown();
            this.lblID = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxAddMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 43);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(107, 40);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(153, 20);
            this.txtBoxFirstName.TabIndex = 1;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(107, 66);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(153, 20);
            this.txtBoxLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 69);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // txtBoxEMail
            // 
            this.txtBoxEMail.Location = new System.Drawing.Point(107, 92);
            this.txtBoxEMail.Name = "txtBoxEMail";
            this.txtBoxEMail.Size = new System.Drawing.Size(153, 20);
            this.txtBoxEMail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 95);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-Mail";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(12, 121);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(46, 13);
            this.lblBalance.TabIndex = 6;
            this.lblBalance.Text = "Balance";
            // 
            // lblAddMoney
            // 
            this.lblAddMoney.AutoSize = true;
            this.lblAddMoney.Location = new System.Drawing.Point(12, 147);
            this.lblAddMoney.Name = "lblAddMoney";
            this.lblAddMoney.Size = new System.Drawing.Size(61, 13);
            this.lblAddMoney.TabIndex = 8;
            this.lblAddMoney.Text = "Add Money";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(107, 171);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(74, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(186, 171);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtBoxBalance
            // 
            this.txtBoxBalance.Location = new System.Drawing.Point(107, 119);
            this.txtBoxBalance.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.txtBoxBalance.Minimum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            -2147483648});
            this.txtBoxBalance.Name = "txtBoxBalance";
            this.txtBoxBalance.Size = new System.Drawing.Size(153, 20);
            this.txtBoxBalance.TabIndex = 12;
            // 
            // txtBoxAddMoney
            // 
            this.txtBoxAddMoney.Location = new System.Drawing.Point(107, 145);
            this.txtBoxAddMoney.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.txtBoxAddMoney.Minimum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            -2147483648});
            this.txtBoxAddMoney.Name = "txtBoxAddMoney";
            this.txtBoxAddMoney.Size = new System.Drawing.Size(153, 20);
            this.txtBoxAddMoney.TabIndex = 13;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 17);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID";
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(107, 14);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.ReadOnly = true;
            this.txtBoxID.Size = new System.Drawing.Size(153, 20);
            this.txtBoxID.TabIndex = 15;
            this.txtBoxID.Text = "-";
            this.txtBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // formAdd_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(272, 202);
            this.ControlBox = false;
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtBoxAddMoney);
            this.Controls.Add(this.txtBoxBalance);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblAddMoney);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.txtBoxEMail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.lblFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "formAdd_Edit";
            this.Text = "Add/Edit";
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxAddMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtBoxEMail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblAddMoney;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        public void setBalanceReadOnly()
        {
            txtBoxBalance.ReadOnly = true;
        }
        public void setFirstNameReadOnly()
        {
            txtBoxFirstName.ReadOnly = true;
        }
        public void setAddMoneyReadOnly()
        {
            txtBoxAddMoney.ReadOnly = true;
        }
        public void setTitle(string title)
        {
            this.Text = title;
        }
        public string getFirstName()
        {
            return txtBoxFirstName.Text;
        }
        public string getID()
        {
            return txtBoxID.Text;
        }
        public void setID(int ID)
        {
            txtBoxID.Text = ID.ToString();
        }
        public void setFirstName(string firstName)
        {
            txtBoxFirstName.Text = firstName;
        }
        public void setLastName(string lastName)
        {
            txtBoxLastName.Text = lastName;
        }
        public void setEMail(string eMail)
        {
            txtBoxEMail.Text = eMail;
        }
        public void setBalance(decimal balance)
        {
            txtBoxBalance.Text = Convert.ToString(balance);
        }
        public string getLastName()
        {
            return txtBoxLastName.Text;
        }
        public string getEMail()
        {
            return txtBoxEMail.Text;
        }
        public decimal getBalance()
        {
            return txtBoxBalance.Value;
        }
        public decimal getAddMoney()
        {
            return txtBoxAddMoney.Value;
}
        public NumericUpDown txtBoxAddMoney;
        public NumericUpDown txtBoxBalance;
        private Label lblID;
        private TextBox txtBoxID;
    }
}