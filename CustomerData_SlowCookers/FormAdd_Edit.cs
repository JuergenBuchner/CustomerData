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
        public Customer customer1;
        public formAdd_Edit(List<Customer> list)
        {
            InitializeComponent();
            listCustomerAll = list;
            customer1 = null;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                Customer tempCust1 = new Customer(this.getFirstName(), this.getLastName(), this.getEMail(), this.getBalance());

                // E-Mail Check if unique
                int id = 0;
                if (getID() != "-")
                {
                    id = Int32.Parse(getID());
                }
                if (checkEmailUnique(listCustomerAll, getEMail(), id))
                {
                    customer1 = tempCust1;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Email is already used.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Issue");
            }


        }

        public bool checkEmailUnique(List<Customer> liste, String email, int row)
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
