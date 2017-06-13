using System;
using System.Windows.Forms;

namespace CustomerData_SlowCookers
{
    partial class FormAdd_Edit
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxEMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtBoxBalance = new System.Windows.Forms.NumericUpDown();
            this.txtBoxAddMoney = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxAddMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(92, 40);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(168, 20);
            this.txtBoxFirstName.TabIndex = 1;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(92, 66);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(168, 20);
            this.txtBoxLastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // txtBoxEMail
            // 
            this.txtBoxEMail.Location = new System.Drawing.Point(92, 92);
            this.txtBoxEMail.Name = "txtBoxEMail";
            this.txtBoxEMail.Size = new System.Drawing.Size(168, 20);
            this.txtBoxEMail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "E-Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Add Money";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(92, 170);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(185, 170);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtBoxBalance
            // 
            this.txtBoxBalance.Location = new System.Drawing.Point(92, 119);
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
            this.txtBoxBalance.Size = new System.Drawing.Size(168, 20);
            this.txtBoxBalance.TabIndex = 12;
            // 
            // txtBoxAddMoney
            // 
            this.txtBoxAddMoney.Location = new System.Drawing.Point(92, 145);
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
            this.txtBoxAddMoney.Size = new System.Drawing.Size(168, 20);
            this.txtBoxAddMoney.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID";
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(92, 14);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.ReadOnly = true;
            this.txtBoxID.Size = new System.Drawing.Size(168, 20);
            this.txtBoxID.TabIndex = 15;
            this.txtBoxID.Text = "-";
            this.txtBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormAdd_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(272, 202);
            this.ControlBox = false;
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxAddMoney);
            this.Controls.Add(this.txtBoxBalance);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxEMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAdd_Edit";
            this.Text = "FormAdd_Edit";
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxAddMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxEMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
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
        private Label label6;
        private TextBox txtBoxID;
    }
}