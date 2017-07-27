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
using System.Collections;

namespace CustomerData_SlowCookers
{
    public partial class formMain : Form
    {
        CustomerList listCustomerAll = new CustomerList();
        List<int> listCustomerFiltered = new List<int>();
        List<int> listCustomerFilteredOld = new List<int>();
        bool[] sortedBoolArray;
        Stream saveStream = null;
        String dateipath = "";
        bool savetoother = false;
        public formMain()
        {
            InitializeComponent();
            // Set Texts in a language
            
            StreamReader reader = new StreamReader("../../../languageData.csv");
            
            string headerLine = reader.ReadLine();
            reader.Close();
            string[] columsEntriesHeader = headerLine.Split(';');
            for (int i = 1; i < columsEntriesHeader.Length; i++)
            {
                cBoxLanguage.Items.Add(columsEntriesHeader[i]);
            }
            cBoxLanguage.SelectedIndex = 0; // Selecting the first language in the combo box
            //ChangeLanguage(cBoxLanguage.SelectedItem.ToString());

            cBoxFilterBy.SelectedIndex = 0;
            /////////////////////////////// FOR TESTING /////////////////////////////////////
            listCustomerAll.Add(new Customer("Jürgen", "Buchner", "juergenB@gmail.com", 20));
            listCustomerAll.Add(new Customer("Jürgen", "Buch", "juergenB@ail.com", 20));
            listCustomerAll.Add(new Customer("Bernd", "Harrer", "zorro@gmail.com", 50));
            listCustomerAll.Add(new Customer("Arnold", "Mair", "M.Arnold@gmail.com", 30));
            /////////////////////////////////////////////////////////////////////////////////
            foreach (Customer cust1 in listCustomerAll)
            {
                listCustomerFiltered.Add(cust1.ID);
            }
            listCustomerFilteredOld = listCustomerFiltered;
            sortedBoolArray = new bool[] { false, false, false, false, false };
            UpdateDataGridView(cBoxFilterBy.SelectedIndex, txtBxFilterBy.Text);
        }

        public static void ChangeLanguage(string language, Form form)
        {
            ControlCollection controls = form.Controls as ControlCollection;
            StreamReader reader = new StreamReader("../../../languageData.csv");

            string headerLine = reader.ReadLine();
            string[] columsEntriesHeader = headerLine.Split(';'); // Here are the languages names
            int columnIdx = Array.FindIndex(columsEntriesHeader, s => s.Equals(language));
            
            while (!reader.EndOfStream)
            {
                try
                {
                    string line = reader.ReadLine();
                    string[] columsEntries = line.Split(';');
                    string prefix = columsEntries[0].Substring(0, 3);
                    if (prefix == "for")
                    {
                        form.Text = columsEntries[columnIdx];
                    }
                    else if (prefix == "tSt")
                    {
                        ToolStrip tStrip = controls[9] as ToolStrip;
                        tStrip.Items[columsEntries[0]].Text = columsEntries[columnIdx];
                    }
                    else if (prefix == "cBo")
                    {
                        string[] cBoxEntries = columsEntries[columnIdx].Split(',');
                        (controls[columsEntries[0]] as ComboBox).Items.Clear();
                        (controls[columsEntries[0]] as ComboBox).Items.AddRange(cBoxEntries);
                        (controls[columsEntries[0]] as ComboBox).SelectedIndex = 0;
                    }
                    else if (prefix == "dgv")
                    {
                        string[] dgvEntries = columsEntries[columnIdx].Split(',');
                        DataGridViewColumnCollection dgvColumns = (controls[columsEntries[0]] as DataGridView).Columns;
                        for (int i = 0; i < dgvColumns.Count; i++)
                        {
                            dgvColumns[i].HeaderText = dgvEntries[i];
                        }
                    }
                    else
                    {
                        (controls[columsEntries[0]] as Control).Text = columsEntries[columnIdx];
                    }
                }
                catch { }
            }            
            reader.Close();
        }

        private void UpdateDataGridView(int filterBy, String stringFilter)
        {
            listCustomerFiltered = CreateFilteredIDList(listCustomerAll, stringFilter, filterBy);
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
                            //first line not necessary, it is the heading of the table
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

        public void decriptData(String id, String balance, String firstName, String lastName, String email)
        {
            int i = 0;
            int j = 0;
            Char[] result = new char[((balance.Length) / 2) + 1];
            //if amount of chars of balance is even
            if ((balance.Length % 2) == 0)
            {
                while (j != (balance.Length))
                {
                    result[i] = balance[j];
                    i++;
                    j += 2;
                }
            } else //if amount of chars of balance is odd
            {
                while (j != (balance.Length + 1)) //otherwise you get an exception
                {
                    result[i] = balance[j];
                    i++;
                    j += 2;
                }
            }

            //Console.WriteLine(result); //only for CHECK 

            int res = 0;
            bool resu = Int32.TryParse(result.ToString(), out res);
            //Console.WriteLine(res); //check if word is decripted correctly

            i = 0;
            j = 0;
            Char[] result1 = new char[((firstName.Length) / 2) + 1];
            //if amount of chars of firstname is even
            if ((firstName.Length % 2) == 0)
            {
                while (j != (firstName.Length))
                {
                    result1[i] = firstName[j];
                    i++;
                    j += 2;
                }
            }
            else   //if amount of chars of firstname is odd
            {
                while(j != (firstName.Length)+1)
                {
                    result1[i] = firstName[j];
                    i++;
                    j += 2;
                }
            }
                        
            //Console.WriteLine(result1); //check if word is decripted correctly

            i = 0;
            j = 0;
            Char[] result2 = new char[((lastName.Length) / 2) + 1];
            //if amount of chars of lastName is even
            if ((lastName.Length % 2) == 0)
            {
                while (j != (lastName.Length))
                {
                    result2[i] = lastName[j];
                    i++;
                    j += 2;
                }
            } else //if amount of chars is odd
            {
                while (j != (lastName.Length)+1)
                {
                    result2[i] = lastName[j];
                    i++;
                    j += 2;
                }
            }

            //Console.WriteLine(result2); //check if word is decripted correctly
            
            i = 0;
            j = 0;
            Char[] result3 = new char[((email.Length) / 2) + 1];
            //if amount  of chars of email is even
            if ((email.Length % 2) == 0)
            {
                while (j != (email.Length))
                {
                    result3[i] = email[j];
                    i++;
                    j += 2;
                }
            } else //if amount of chars is odd
            {
                while (j != (email.Length)+1)
                {
                    result3[i] = email[j];
                    i++;
                    j += 2;
                }
            }
            
            //Console.WriteLine(result3); //check if word is decripted correctly

            //formAdd_Edit form1 = new formAdd_Edit(listCustomerAll);
            //if check is wrong, data set isn't shown in the list
            //result1.length-1 because otherwise you check also the \0 (end of char[]) 
            if (Customer.checkName(new String(result1, 0, result1.Length - 1)) && Customer.checkName(new string(result2, 0, result2.Length - 1)) && Customer.eMailOK(new string(result3, 0, result3.Length - 1)))
            {
                //Console.WriteLine("First name right");
                listCustomerAll.Add(new Customer(new string(result1), new string(result2), new string(result3), new decimal(res)));
                foreach (Customer cust1 in listCustomerAll)
                {
                    listCustomerFiltered.Add(cust1.ID);
                }
            }
            UpdateDataGridView(cBoxFilterBy.SelectedIndex, txtBxFilterBy.Text);
        }

        public string encriptData(String id, String balance, String firstName, String lastName, String email)
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
                resultbal[i] = Convert.ToChar('a' + caseSwitch - 1);
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
                resultfirst[i] = Convert.ToChar('a' + caseSwitch - 1);
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
                resultlast[i] = Convert.ToChar('a' + caseSwitch - 1);
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
                resultmail[i] = Convert.ToChar('a' + caseSwitch - 1);
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
            formAdd_Edit form1 = new formAdd_Edit(listCustomerAll);
            ChangeLanguage(cBoxLanguage.SelectedItem.ToString(), form1);
            form1.txtBoxAddMoney.Enabled = false;

            form1.setTitle((sender as Button).Text);
            if (form1.ShowDialog() == DialogResult.OK)
            {
                listCustomerAll.Add(form1.customer1);
                writeCSV(listCustomerAll);
                UpdateDataGridView(cBoxFilterBy.SelectedIndex, txtBxFilterBy.Text);
            }
        }


        private bool writeCSV(List<Customer> ListWriteAll)
        {           
            try
            {
                if (saveStream.Equals(""))
                {
                    //exception is thrown
                } else if (savetoother.Equals(true))   //wenn save button gedrückt wird
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
                    saveFileDialog.FilterIndex = 2;
                    saveFileDialog.RestoreDirectory = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            if ((saveStream = saveFileDialog.OpenFile()) != null)
                            {
                                dateipath = saveFileDialog.FileName;
                                Console.WriteLine(dateipath);
                                using (StreamWriter sw = new StreamWriter(saveStream))
                                {
                                    sw.WriteLine("ID;Balance;FirstName;LastName;Email");

                                    formAdd_Edit form1 = new formAdd_Edit(listCustomerAll);

                                    foreach (var l in listCustomerAll)
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
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: Could not write to file from disk. Original error: " + ex.Message);
                        }
                    }
                    
                }

                else
                {
                    
                    using (StreamWriter sw = new StreamWriter(dateipath ,false))
                    {
                        sw.WriteLine("ID;Balance;FirstName;LastName;Email");

                        formAdd_Edit form1 = new formAdd_Edit(listCustomerAll);

                        foreach (var l in listCustomerAll)
                        {
                            String res = encriptData(l.ID.ToString(), l.Balance.ToString(), l.FirstName, l.LastName, l.eMail);
                            Console.WriteLine(res);
                        sw.WriteLine(res);

                        }
                    sw.Close();
                    }
                    saveStream.Close();
                    return true;
                }
            }
            
            catch (Exception e)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if ((saveStream = saveFileDialog.OpenFile()) != null)
                        {
                            dateipath = saveFileDialog.FileName;
                            Console.WriteLine(dateipath);
                            using (StreamWriter sw = new StreamWriter(saveStream))
                            {
                                sw.WriteLine("ID;Balance;FirstName;LastName;Email");

                                formAdd_Edit form1 = new formAdd_Edit(listCustomerAll);

                                foreach (var l in listCustomerAll)
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
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not write to file from disk. Original error: " + ex.Message);
                    }
                }
            } 
            return false;
        }




        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgvFiltered.SelectedRows.Count > 0)
            {
                formAdd_Edit form1 = new formAdd_Edit(listCustomerAll);
                ChangeLanguage(cBoxLanguage.SelectedItem.ToString(), form1);
                //form1.setBalanceReadOnly();
                form1.txtBoxBalance.Enabled = false;
                form1.setFirstNameReadOnly();

                // Import Data of selected Customer
                Customer cust1 = (Customer)dgvFiltered.SelectedRows[0].DataBoundItem;
                form1.setID(cust1.ID);
                form1.setFirstName(cust1.FirstName);
                form1.setLastName(cust1.LastName);
                form1.setEMail(cust1.eMail);
                form1.setBalance(cust1.Balance);

                form1.setTitle((sender as Button).Text);
                if (form1.ShowDialog() == DialogResult.OK)
                {
                    cust1.FirstName = form1.getFirstName();
                    cust1.LastName = form1.getLastName();
                    cust1.eMail = form1.getEMail();
                    cust1.addMoney(form1.getAddMoney());
                    UpdateDataGridView(cBoxFilterBy.SelectedIndex, txtBxFilterBy.Text);
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
            UpdateDataGridView(cBoxFilterBy.SelectedIndex, txtBxFilterBy.Text);
        }
        ///<summary>
        /// filterBy = 0: Filters by the first name. 
        /// filterBy = 1: Filters by the last name
        ///</summary>
        public static List<int> CreateFilteredIDList(List<Customer> list, string stringFilter, int filterBy)
        {

            List<int> IDListFiltCustomer = new List<int>();
            
            if (stringFilter != "")
            {
                switch (filterBy)
                {
                    case 0: // the string of the selected item of cBoxFilterby was not chosen because of the different languages
                        foreach (Customer cust1 in list)
                        {
                            if (cust1.FirstName.Contains(stringFilter))
                            {
                                IDListFiltCustomer.Add(cust1.ID);
                            }
                        }
                        break;
                    case 1:
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
            string[] customerProperties = new string[] { "ID", "FirstName", "LastName", "eMail", "Balance" };

            if (sortedBoolArray[e.ColumnIndex] == false) // If list is already sorted ascending by ID, the list will be sorted descending 
            {
                listCustomerAll.ReplaceByIndexedList(listCustomerAll.OrderBy(o => typeof(Customer).GetProperty(customerProperties[e.ColumnIndex]).GetValue(o, null)).ToList()); // Sorting the list ascending by ID
                sortedBoolArray = new bool[] { false, false, false, false, false }; // setting that the list is sorted ascending by ID
                sortedBoolArray[e.ColumnIndex] = true;
            }
            else
            {
                listCustomerAll.ReplaceByIndexedList(listCustomerAll.OrderByDescending(o => typeof(Customer).GetProperty(customerProperties[e.ColumnIndex]).GetValue(o, null)).ToList()); // Sorting the list descending by ID
                sortedBoolArray = new bool[] { false, false, false, false, false }; // setting that the list is not sorted ascending in any way (in this case sorted descending by ID)
            }

            UpdateDataGridView(cBoxFilterBy.SelectedIndex, txtBxFilterBy.Text);
        }

        public void cBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeLanguage(cBoxLanguage.SelectedItem.ToString(),FindForm());
        }

        private void dgvFiltered_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tStripSaveFile_Click(object sender, EventArgs e)
        {
            savetoother = true;
            writeCSV(listCustomerAll);
            savetoother = false; 
        }
    }
}
