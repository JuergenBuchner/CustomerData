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
    public partial class formAdd_Edit : Form
    {
        private List<Customer> listCustomerAll;

        public formAdd_Edit(List<Customer> list)
        {
            InitializeComponent();
            listCustomerAll = list;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int errorCount = 0;
            // Check First Name
            if (!checkName(txtBoxFirstName.Text))
            {
                errorCount += 1;
                MessageBox.Show("The First Name only allows characters, the first needs to be big, the others small. Lenght needs to be at least 2", "First Name Issue");
            }

            // Check Last Name
            if (!checkName(txtBoxLastName.Text))
            {
                errorCount += 1;
                MessageBox.Show("The Last Name only allows characters, the first needs to be big, the others small. Lenght needs to be at least 2", "Last Name Issue");
            }

            // E-Mail Check
            if (eMailOK(txtBoxEMail.Text.ToString()))
            {
                int id = 0;
                if(getID() != "-")
                {
                    id = Int32.Parse(getID());
                }
                if (checkEmailUnique(listCustomerAll, getEMail(), id))
                {
                    
                }
                else
                {
                    errorCount += 1;
                    MessageBox.Show("Email is already used.");
                }
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

        public bool checkName(string name)
        {
            if (name == String.Empty
                || !Char.IsUpper(name.First())
                || !name.Substring(1).All(Char.IsLower)
                || !name.All(Char.IsLetter)
                || name.Length < 2)
            {
                return false;
            }
            else
            {
                return true;
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

        private bool checkEmailUnique(List<Customer> liste, String email, int row)
        {
            int count = 0;
            foreach (var l in liste)
            {
                if (!(l.eMail.Equals(email)))
                {
                    count++;
                }
                else
                {
                    if (l.eMail.Equals(email) && l.ID.Equals(row))
                    {
                        return true;
                    }
                }
            }
            if (count == liste.Count)
            {
                return true;
            }
            return false;
        }

    }
}
