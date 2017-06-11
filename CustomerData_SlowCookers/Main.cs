using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CustomerData_SlowCookers
{
    public partial class Main : Form
    {
        List<Customer> listCustomerAll = new List<Customer>();
        List<int> listCustomerFiltered = new List<int>();
        List<int> listCustomerFilteredOld = new List<int>();
        bool[] sortedBoolArray;
        public Main()
        {
            InitializeComponent();
            cBoxFilterBy.Items.Add("First Name");
            cBoxFilterBy.Items.Add("Last Name");
            cBoxFilterBy.SelectedIndex = 0;
            ///////////////////////// CHRISSI : FOR TESTING ////////////////////////////////
            listCustomerAll.Add(new Customer("Jürgen", "Buchner", "juergenB@gmail.com", 20));
            listCustomerAll.Add(new Customer("Bernd", "Harrer", "zorro@gmail.com", 50));
            listCustomerAll.Add(new Customer("Arnold", "Mair", "M.Arnold@gmail.com", 30));
            /////////////////////////////////////////////////////////////////////////////////
            foreach (Customer cust1 in listCustomerAll)
            {
                listCustomerFiltered.Add(cust1.ID);
            }
            listCustomerFilteredOld = listCustomerFiltered;
            sortedBoolArray = new bool[] { false, false, false, false, false };
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            customerBindingSource1.Clear();
            foreach ( Customer item in listCustomerAll)
            {
                if(listCustomerFiltered.Contains(item.ID))
                {
                    customerBindingSource1.Add(item);
                }               
            }
        }

        private void dataToolStripMenuItemChooseFile_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "CSV files (*.csv)|*.csv";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // CHRISSI PART: Insert code to read the stream here.
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            FormAdd_Edit form1 = new FormAdd_Edit();
            form1.setAddMoneyReadOnly();
            form1.setTitle("Add");
            if (form1.ShowDialog() == DialogResult.OK)
            {
                if (true) // CHRISSI PART: if "checkEntry" function true -> Save to ListAll & update ListBoxFiltered
                {
                    listCustomerAll.Add(new Customer(form1.getFirstName(), form1.getLastName(), form1.getEMail(), form1.getBalance()));
                    UpdateDataGridView();
                }
                // CHRISSI PART: else -> MessageBox Error
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dataGViewFiltered.SelectedRows.Count > 0)
            {
                FormAdd_Edit form1 = new FormAdd_Edit();
                form1.setBalanceReadOnly();
                form1.setFirstNameReadOnly();

                // Import Data of selected Customer
                Customer cust1 = (Customer)dataGViewFiltered.SelectedRows[0].DataBoundItem;
                form1.setFirstName(cust1.FirstName);
                form1.setLastName(cust1.LastName);
                form1.setEMail(cust1.eMail);
                form1.setBalance(cust1.Balance);

                form1.setTitle("Edit");
                if (form1.ShowDialog() == DialogResult.OK)
                {
                    if (true) // CHRISSI PART: if "checkEntry" function true -> Save to ListAll & update ListBoxFiltered
                    {
                        cust1.FirstName = form1.getFirstName();
                        cust1.LastName = form1.getLastName();
                        cust1.eMail = form1.getEMail();
                        cust1.addMoney(form1.getAddMoney());
                        UpdateDataGridView();
                    }
                    // CHRISSI PART: else -> MessageBox Error
                }
            }
            else
            {
                MessageBox.Show("No customer was selected!","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnShowFilteredList_Click(object sender, EventArgs e)
        {
            string filterBy = cBoxFilterBy.Text;
            String stringFilter = txtBxFilterBy.Text;
            listCustomerFiltered = CreateFilteredIDList(listCustomerAll, stringFilter, filterBy);
            // Update Filtered List -> Show
            // If txtBxFilterBy.Text is null -> Show All entries of the list
            UpdateDataGridView();
        }

        public static List<int> CreateFilteredIDList(List<Customer> list, string stringFilter, string filterBy)
        {

            List<int> IDListFiltCustomer = new List<int>();
            
            if (stringFilter != "")
            {
                switch (filterBy)
                {
                    case "First Name":
                        foreach (Customer cust1 in list)
                        {
                            if (cust1.FirstName.Contains(stringFilter))
                            {
                                IDListFiltCustomer.Add(cust1.ID);
                            }
                        }
                        break;
                    case "Last Name":
                        foreach (Customer cust1 in list)
                        {
                            if (cust1.LastName.Contains(stringFilter))
                            {
                                IDListFiltCustomer.Add(cust1.ID);
                            }
                        }
                        break;
                }
            }
            else
            {
                foreach (Customer cust1 in list)
                {
                    IDListFiltCustomer.Add(cust1.ID);
                }
            }

            return IDListFiltCustomer;
        }

        private void dataGViewFiltered_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    if (sortedBoolArray[0] == false) // If list is already sorted ascending by ID, the list will be sorted descending 
                    {
                        listCustomerAll = listCustomerAll.OrderBy(o => o.ID).ToList(); // Sorting the list ascending by ID
                        sortedBoolArray = new bool[] { true, false, false, false, false }; // setting that the list is sorted ascending by ID
                    }
                    else
                    {
                        listCustomerAll = listCustomerAll.OrderByDescending(o => o.ID).ToList(); // Sorting the list descending by ID
                        sortedBoolArray = new bool[] { false, false, false, false, false }; // setting that the list is not sorted ascending in any way (in this case sorted descending by ID)
                    }
                    break;
                case 1:
                    if (sortedBoolArray[1] == false) // If list is already sorted ascending by Balance, the list will be sorted descending 
                    {
                        listCustomerAll = listCustomerAll.OrderBy(o => o.Balance).ToList(); // Sorting the list ascending by Balance
                        sortedBoolArray = new bool[] { false, true, false, false, false }; // setting that the list is sorted ascending by Balance
                    }
                    else
                    {
                        listCustomerAll = listCustomerAll.OrderByDescending(o => o.Balance).ToList(); // Sorting the list descending by Balance
                        sortedBoolArray = new bool[] { false, false, false, false, false }; // setting that the list is not sorted ascending in any way (in this case sorted descending by Balance)
                    }
                    break;
                case 2:
                    if (sortedBoolArray[2] == false)
                    {
                        listCustomerAll = listCustomerAll.OrderBy(o => o.FirstName).ToList();
                        sortedBoolArray = new bool[] { false, false, true, false, false };
                    }
                    else
                    {
                        listCustomerAll = listCustomerAll.OrderByDescending(o => o.FirstName).ToList();
                        sortedBoolArray = new bool[] { false, false, false, false, false };
                    }
                    break;
                case 3:
                    if (sortedBoolArray[3] == false)
                    {
                        listCustomerAll = listCustomerAll.OrderBy(o => o.LastName).ToList();
                        sortedBoolArray = new bool[] { false, false, false, true, false };
                    }
                    else
                    {
                        listCustomerAll = listCustomerAll.OrderByDescending(o => o.LastName).ToList();
                        sortedBoolArray = new bool[] { false, false, false, false, false };
                    }
                    break;
                case 4:
                    if (sortedBoolArray[4] == false)
                    {
                        listCustomerAll = listCustomerAll.OrderBy(o => o.eMail).ToList();
                        sortedBoolArray = new bool[] { false, false, false, false, true };
                    }
                    else
                    {
                        listCustomerAll = listCustomerAll.OrderByDescending(o => o.eMail).ToList();
                        sortedBoolArray = new bool[] { false, false, false, false, false };
                    }
                    break;
            }
            UpdateDataGridView();
        }
    }
}
