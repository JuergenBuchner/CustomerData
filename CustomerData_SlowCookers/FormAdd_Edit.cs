using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerData_SlowCookers
{
    public partial class FormAdd_Edit : Form
    {
        public FormAdd_Edit()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int errorCount = 0;
            // Check First Name
            if(!Char.IsUpper(txtBoxFirstName.Text.First())
                || !txtBoxFirstName.Text.Substring(1).All(Char.IsLower)
                || !txtBoxFirstName.Text.All(Char.IsLetter) 
                || txtBoxFirstName.Text.Length < 2)
            {
                errorCount += 1;
                MessageBox.Show("The First Name only allows characters, the first needs to be big, the others small. Lenght needs to be at least 2", "First Name Issue");
            }

            // Check Last Name
            if (!Char.IsUpper(txtBoxLastName.Text.First())
                || !txtBoxLastName.Text.Substring(1).All(Char.IsLower)
                || !txtBoxLastName.Text.All(Char.IsLetter) 
                || txtBoxLastName.Text.Length < 2)
            {
                errorCount += 1;
                MessageBox.Show("The Last Name only allows characters, the first needs to be big, the others small. Lenght needs to be at least 2", "Last Name Issue");
            }

            // E-Mail Check
            if (eMailOK(txtBoxEMail.Text.ToString()))
            {
                //Nothing to do here
            }
            else
            {
                errorCount += 1;
                MessageBox.Show("The Email address only allows characters, numbers and this special symbols(!#$%&'*+-/=?^_`{|}~) in front of the @ sign, after the @ sign characters, numbers and special symbols are allowed. A dot is allowed after the @ sign and one char.");
            }


            if (errorCount <= 0)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private bool eMailOK(String email)
        {
            string pattern = @"[a-zA-Z0-9!#$%\&'\*\+\-\/=\?\^_`\{|\}~]+@{1}[a-zA-Z0-9!#$%\&'\*\+\-\/=\?\^_`\{|\}~]+[\.]?[a-zA-Z0-9!#$%\&'\*\+\-\/=\?\^_`\{|\}~]+[\.]{1}[a-z,A-Z]{2,4}";

            Regex rgx = new Regex(pattern);
            MatchCollection matches = rgx.Matches(email);
            if (matches.Count > 0)
            {
                return true;
            }
            return false;


        }
    }
}
