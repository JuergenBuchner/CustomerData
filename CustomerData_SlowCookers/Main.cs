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
                            StreamReader sr = new StreamReader(myStream);
                            string line;
                            //erste Zeile wird nicht benötigt, es handelt sich hier um die Tabellenüberschriften
                            line = sr.ReadLine();

                            while ((line = sr.ReadLine()) != null)
                            {

                                String[] splitting = line.Split(';');

                                String id = splitting[0];
                                String balance = splitting[1];
                                String firstName = splitting[2];
                                String lastName = splitting[3];
                                String email = splitting[4];

                                decriptData(id, balance, firstName, lastName, email);

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void decriptData(String id, String balance, String firstName, String lastName, String email)
        {

            var chars = balance.ToCharArray();
            Char[] result = new char[((balance.Length) / 2) + 1];
            int i = 0;
            int j = 0;
            while (j != (balance.Length))
            {
                result[i] = balance[j];
                i++;
                j += 2;
            }
            Console.WriteLine(result);

            int res = 0;
            bool resu = Int32.TryParse(result.ToString(), out res);


            var chars1 = firstName.ToCharArray();
            Char[] result1 = new char[((firstName.Length) / 2) + 1];
            i = 0;
            j = 0;
            while (j != (firstName.Length))
            {
                result1[i] = firstName[j];
                i++;
                j += 2;
            }
            Console.WriteLine(result1);

            var chars2 = lastName.ToCharArray();
            Char[] result2 = new char[((lastName.Length) / 2) + 1];
            i = 0;
            j = 0;
            while (j != (lastName.Length))
            {
                result2[i] = lastName[j];
                i++;
                j += 2;
            }
            Console.WriteLine(result2);

            var chars3 = email.ToCharArray();
            Char[] result3 = new char[((email.Length) / 2) + 1];
            i = 0;
            j = 0;
            while (j != (email.Length))
            {
                result3[i] = email[j];
                i++;
                j += 2;
            }
            Console.WriteLine(result3);

            listCustomerAll.Add(new Customer(result1.ToString(), result2.ToString(), result3.ToString(), res));
            UpdateDataGridView();
        }

        private string encriptData(String id, String balance, String firstName, String lastName, String email)
        {

            var bal = balance.ToCharArray();
            Char[] resultbal = new char[((balance.Length) * 2) + 1];

            int i = 0;
            int j = 0;
            Random rand = new Random();


            while (j != (balance.Length))
            {
                resultbal[i] = balance[j];
                i++;
                j++;

                int caseSwitch = rand.Next(27);

                switch (caseSwitch)
                {
                    case 1:
                        resultbal[i] = 'a';
                        break;
                    case 2:
                        resultbal[i] = 'b';
                        break;
                    case 3:
                        resultbal[i] = 'c';
                        break;
                    case 4:
                        resultbal[i] = 'd';
                        break;
                    case 5:
                        resultbal[i] = 'e';
                        break;
                    case 6:
                        resultbal[i] = 'f';
                        break;
                    case 7:
                        resultbal[i] = 'g';
                        break;
                    case 8:
                        resultbal[i] = 'h';
                        break;
                    case 9:
                        resultbal[i] = 'i';
                        break;
                    case 10:
                        resultbal[i] = 'j';
                        break;
                    case 11:
                        resultbal[i] = 'k';
                        break;
                    case 12:
                        resultbal[i] = 'l';
                        break;
                    case 13:
                        resultbal[i] = 'm';
                        break;
                    case 14:
                        resultbal[i] = 'n';
                        break;
                    case 15:
                        resultbal[i] = 'o';
                        break;
                    case 16:
                        resultbal[i] = 'p';
                        break;
                    case 17:
                        resultbal[i] = 'q';
                        break;
                    case 18:
                        resultbal[i] = 'r';
                        break;
                    case 19:
                        resultbal[i] = 's';
                        break;
                    case 21:
                        resultbal[i] = 't';
                        break;
                    case 22:
                        resultbal[i] = 'u';
                        break;
                    case 23:
                        resultbal[i] = 'v';
                        break;
                    case 24:
                        resultbal[i] = 'w';
                        break;
                    case 25:
                        resultbal[i] = 'x';
                        break;
                    case 26:
                        resultbal[i] = 'y';
                        break;
                    case 27:
                        resultbal[i] = 'z';
                        break;
                    default:
                        resultbal[i] = 'A';
                        break;
                }
                i++;
            }

            var first = firstName.ToCharArray();
            Char[] resultfirst = new char[((firstName.Length) * 2) + 1];

            i = 0;
            j = 0;

            while (j != (firstName.Length))
            {
                resultfirst[i] = firstName[j];
                i++;
                j++;

                int caseSwitch = rand.Next(27);

                switch (caseSwitch)
                {
                    case 1:
                        resultfirst[i] = 'a';
                        break;
                    case 2:
                        resultfirst[i] = 'b';
                        break;
                    case 3:
                        resultfirst[i] = 'c';
                        break;
                    case 4:
                        resultfirst[i] = 'd';
                        break;
                    case 5:
                        resultfirst[i] = 'e';
                        break;
                    case 6:
                        resultfirst[i] = 'f';
                        break;
                    case 7:
                        resultfirst[i] = 'g';
                        break;
                    case 8:
                        resultfirst[i] = 'h';
                        break;
                    case 9:
                        resultfirst[i] = 'i';
                        break;
                    case 10:
                        resultfirst[i] = 'j';
                        break;
                    case 11:
                        resultfirst[i] = 'k';
                        break;
                    case 12:
                        resultfirst[i] = 'l';
                        break;
                    case 13:
                        resultfirst[i] = 'm';
                        break;
                    case 14:
                        resultfirst[i] = 'n';
                        break;
                    case 15:
                        resultfirst[i] = 'o';
                        break;
                    case 16:
                        resultfirst[i] = 'p';
                        break;
                    case 17:
                        resultfirst[i] = 'q';
                        break;
                    case 18:
                        resultfirst[i] = 'r';
                        break;
                    case 19:
                        resultfirst[i] = 's';
                        break;
                    case 21:
                        resultfirst[i] = 't';
                        break;
                    case 22:
                        resultfirst[i] = 'u';
                        break;
                    case 23:
                        resultfirst[i] = 'v';
                        break;
                    case 24:
                        resultfirst[i] = 'w';
                        break;
                    case 25:
                        resultfirst[i] = 'x';
                        break;
                    case 26:
                        resultfirst[i] = 'y';
                        break;
                    case 27:
                        resultfirst[i] = 'z';
                        break;
                    default:
                        resultfirst[i] = 'A';
                        break;
                }
                i++;
            }

            var last = lastName.ToCharArray();
            Char[] resultlast = new char[((lastName.Length) * 2) + 1];

            i = 0;
            j = 0;

            while (j != (lastName.Length))
            {
                resultlast[i] = lastName[j];
                i++;
                j++;

                int caseSwitch = rand.Next(27);

                switch (caseSwitch)
                {
                    case 1:
                        resultlast[i] = 'a';
                        break;
                    case 2:
                        resultlast[i] = 'b';
                        break;
                    case 3:
                        resultlast[i] = 'c';
                        break;
                    case 4:
                        resultlast[i] = 'd';
                        break;
                    case 5:
                        resultlast[i] = 'e';
                        break;
                    case 6:
                        resultlast[i] = 'f';
                        break;
                    case 7:
                        resultlast[i] = 'g';
                        break;
                    case 8:
                        resultlast[i] = 'h';
                        break;
                    case 9:
                        resultlast[i] = 'i';
                        break;
                    case 10:
                        resultlast[i] = 'j';
                        break;
                    case 11:
                        resultlast[i] = 'k';
                        break;
                    case 12:
                        resultlast[i] = 'l';
                        break;
                    case 13:
                        resultlast[i] = 'm';
                        break;
                    case 14:
                        resultlast[i] = 'n';
                        break;
                    case 15:
                        resultlast[i] = 'o';
                        break;
                    case 16:
                        resultlast[i] = 'p';
                        break;
                    case 17:
                        resultlast[i] = 'q';
                        break;
                    case 18:
                        resultlast[i] = 'r';
                        break;
                    case 19:
                        resultlast[i] = 's';
                        break;
                    case 21:
                        resultlast[i] = 't';
                        break;
                    case 22:
                        resultlast[i] = 'u';
                        break;
                    case 23:
                        resultlast[i] = 'v';
                        break;
                    case 24:
                        resultlast[i] = 'w';
                        break;
                    case 25:
                        resultlast[i] = 'x';
                        break;
                    case 26:
                        resultlast[i] = 'y';
                        break;
                    case 27:
                        resultlast[i] = 'z';
                        break;
                    default:
                        resultlast[i] = 'A';
                        break;
                }
                i++;
            }

            var mail = email.ToCharArray();
            Char[] resultmail = new char[((email.Length) * 2) + 1];

            i = 0;
            j = 0;

            while (j != (email.Length))
            {
                resultmail[i] = email[j];
                i++;
                j++;

                int caseSwitch = rand.Next(27);

                switch (caseSwitch)
                {
                    case 1:
                        resultmail[i] = 'a';
                        break;
                    case 2:
                        resultmail[i] = 'b';
                        break;
                    case 3:
                        resultmail[i] = 'c';
                        break;
                    case 4:
                        resultmail[i] = 'd';
                        break;
                    case 5:
                        resultmail[i] = 'e';
                        break;
                    case 6:
                        resultmail[i] = 'f';
                        break;
                    case 7:
                        resultmail[i] = 'g';
                        break;
                    case 8:
                        resultmail[i] = 'h';
                        break;
                    case 9:
                        resultmail[i] = 'i';
                        break;
                    case 10:
                        resultmail[i] = 'j';
                        break;
                    case 11:
                        resultmail[i] = 'k';
                        break;
                    case 12:
                        resultmail[i] = 'l';
                        break;
                    case 13:
                        resultmail[i] = 'm';
                        break;
                    case 14:
                        resultmail[i] = 'n';
                        break;
                    case 15:
                        resultmail[i] = 'o';
                        break;
                    case 16:
                        resultmail[i] = 'p';
                        break;
                    case 17:
                        resultmail[i] = 'q';
                        break;
                    case 18:
                        resultmail[i] = 'r';
                        break;
                    case 19:
                        resultmail[i] = 's';
                        break;
                    case 21:
                        resultmail[i] = 't';
                        break;
                    case 22:
                        resultmail[i] = 'u';
                        break;
                    case 23:
                        resultmail[i] = 'v';
                        break;
                    case 24:
                        resultmail[i] = 'w';
                        break;
                    case 25:
                        resultmail[i] = 'x';
                        break;
                    case 26:
                        resultmail[i] = 'y';
                        break;
                    case 27:
                        resultmail[i] = 'z';
                        break;
                    default:
                        resultmail[i] = 'A';
                        break;
                }
                i++;
            }

            balance = new string(resultbal);
            firstName = new string(resultfirst);
            lastName = new string(resultlast);
            email = new string(resultmail);


            String result = (id + ";" + balance + ";" + firstName + ";" + lastName + ";" + email);

            return result;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            FormAdd_Edit form1 = new FormAdd_Edit(listCustomerAll);
            //form1.setAddMoneyReadOnly();
            form1.txtBoxAddMoney.Enabled = false;

            form1.setTitle("Add");
            if (form1.ShowDialog() == DialogResult.OK)
            {
                listCustomerAll.Add(new Customer(form1.getFirstName(), form1.getLastName(), form1.getEMail(), form1.getBalance()));
                UpdateDataGridView();
                writeCSV(listCustomerAll);
            }
        }


        private bool writeCSV(List<Customer> ListWriteAll)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "|*.csv";
            saveFile.Title = "Save CSV File";
            saveFile.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFile.FileName != "")
            {
                using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                {
                    sw.WriteLine("ID;Balance;FirstName;LastName;Email");
                    foreach (var l in ListWriteAll)
                    {
                        String res = encriptData(l.ID.ToString(), l.Balance.ToString(), l.FirstName, l.LastName, l.eMail);
                        Console.WriteLine(res);
                        sw.WriteLine(res);
                    }
                    sw.Close();
                }
                return true;
            }

            return false;
        }



        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dataGViewFiltered.SelectedRows.Count > 0)
            {
                FormAdd_Edit form1 = new FormAdd_Edit(listCustomerAll);
                //form1.setBalanceReadOnly();
                form1.txtBoxBalance.Enabled = false;
                form1.setFirstNameReadOnly();

                // Import Data of selected Customer
                Customer cust1 = (Customer)dataGViewFiltered.SelectedRows[0].DataBoundItem;
                form1.setID(cust1.ID);
                form1.setFirstName(cust1.FirstName);
                form1.setLastName(cust1.LastName);
                form1.setEMail(cust1.eMail);
                form1.setBalance(cust1.Balance);

                form1.setTitle("Edit");
                if (form1.ShowDialog() == DialogResult.OK)
                {
                    cust1.FirstName = form1.getFirstName();
                    cust1.LastName = form1.getLastName();
                    cust1.eMail = form1.getEMail();
                    cust1.addMoney(form1.getAddMoney());
                    UpdateDataGridView();
                    writeCSV(listCustomerAll);
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
            string[] customerProperties = new string[] { "ID", "Balance", "FirstName", "LastName", "eMail" };

            if (sortedBoolArray[e.ColumnIndex] == false) // If list is already sorted ascending by ID, the list will be sorted descending 
            {
                listCustomerAll = listCustomerAll.OrderBy(o => typeof(Customer).GetProperty(customerProperties[e.ColumnIndex]).GetValue(o, null)).ToList(); // Sorting the list ascending by ID
                sortedBoolArray = new bool[] { false, false, false, false, false }; // setting that the list is sorted ascending by ID
                sortedBoolArray[e.ColumnIndex] = true;
            }
            else
            {
                listCustomerAll = listCustomerAll.OrderByDescending(o => typeof(Customer).GetProperty(customerProperties[e.ColumnIndex]).GetValue(o, null)).ToList(); // Sorting the list descending by ID
                sortedBoolArray = new bool[] { false, false, false, false, false }; // setting that the list is not sorted ascending in any way (in this case sorted descending by ID)
            }

            UpdateDataGridView();
        }
    }
}
