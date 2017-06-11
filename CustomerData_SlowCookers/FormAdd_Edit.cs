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
            if(!checkName(txtBoxFirstName.Text))
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
            bool eMailOK = true; // CHRISSI Part: Needs to be changed to a eMail Check
            if (!eMailOK)
            {
                errorCount += 1;
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
    }
}
