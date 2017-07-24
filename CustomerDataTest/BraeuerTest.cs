using CustomerData_SlowCookers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDataTest
{
    [TestClass]
    public class BraeuerTest
    {
        private List<Customer> ListCustomer;

        [TestInitialize()]
        public void Initialize()
        {
            ListCustomer = new List<Customer>();
            ListCustomer.Add(new Customer("Jürgen", "Buchner", "juergenB@gmail.com", 20));
            ListCustomer.Add(new Customer("Bernd", "Harrer", "zorro@gmail.com", 50));
            ListCustomer.Add(new Customer("Arnold", "Mair", "M.Arnold@gmail.com", 30));
            ListCustomer.Add(new Customer("Bernhard", "Mair", "asdro@gmail.com", 10));

        }
      
        [TestMethod]
        public void ValidEncriptData()
        {
            string[] realData = { "Alex", "Binder", "alex.binder@gmail.com", "20" };
            formMain main = new formMain();
            string id = "1";

            string encripted = main.encriptData(id, realData[3], realData[0], realData[1],realData[2]);
            //veD = valid encript Data
            string[] encriptedsplitted = encripted.Split(';');

            bool veD = true;
            if (encriptedsplitted[1].Equals(realData[3]) && encriptedsplitted[2].Equals(realData[0]) && encriptedsplitted[3].Equals(realData[1]) && encriptedsplitted[4].Equals(realData[2]))
            {
                veD = false;                
            }
            Assert.IsTrue(veD);
        }

        [TestMethod]
        public void ValidLanguageSelect()
        {
            string languagefilter = "Deutsch";
            string wantedlanguage = "Deutsch";
            formMain main = new formMain();
            bool languageOK = true;
            main.cBoxLanguage.SelectedItem = wantedlanguage;
            if (!main.cBoxLanguage.SelectedItem.Equals(languagefilter))
            {
                languageOK = false;              
            }
            Assert.IsTrue(languageOK);
        }

        [TestMethod]
        public void ValidEmailOk()
        {
            string[] validEmail = { "juliaH@gmail.com", "zorro@gmail.com", "ferdinand.huber@gmx.net" };
            formAdd_Edit form = new formAdd_Edit(ListCustomer);
            bool emailOK = true;

            foreach(string email in validEmail)
            {
                if (!Customer.eMailOK(email))
                {
                    emailOK = false;
                    break;
                }
            }
            Assert.IsTrue(emailOK);
        }

        [TestMethod]
        public void InvalidEmailOk()
        {
            string[] invalidEmail = { "zorro@gmail.a", "schimpi@gmail", "b@gmx.345" };
            formAdd_Edit form = new formAdd_Edit(ListCustomer);
            bool emailOk = false;

            foreach(string email in invalidEmail)
            {
                if (Customer.eMailOK(email))
                {
                    emailOk = true;
                    break;
                }
            }
            Assert.IsFalse(emailOk);
        }
        
        [TestMethod]
        public void ValidEmailUnique()
        {
            string[] validEmails = { "juliaHieb@gmx.net", "ferdinand.halbmayr@abc.de", "Luke.Edel@yahoo.com" };
            formAdd_Edit form = new formAdd_Edit(ListCustomer);
            bool emailUnique = true;

            foreach (string email in validEmails)
            {
                if (!form.checkEmailUnique(ListCustomer,email,2))
                {
                    emailUnique = false;
                    break;
                }
            }
            Assert.IsTrue(emailUnique);
        }
        
        [TestMethod]
        public void InvalidEmailUnique()
        {
            string[] invalidEmails = {"M.Arnold@gmail.com", "asdro@gmail.com"};
            formAdd_Edit form = new formAdd_Edit(ListCustomer);
            bool emailUnique = false;

            foreach (string email in invalidEmails)
            {
                if (form.checkEmailUnique(ListCustomer,email,2))
                {
                    emailUnique = true;
                    break;
                }
            }
            Assert.IsFalse(emailUnique);
        }
    }
}
