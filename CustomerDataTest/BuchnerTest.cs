using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerData_SlowCookers;
using System.Collections.Generic;
using System.Linq;

namespace BuchnerTest
{
    [TestClass]
    public class BuchnerTest
    {
        private List<Customer> ListCustomer;

        [TestInitialize()]
        public void Initialize()
        {
            Customer.idCount = 1;
            ListCustomer = new List<Customer>();
            ListCustomer.Add(new Customer("Jürgen", "Buchner", "juergenB@gmail.com", 20));
            ListCustomer.Add(new Customer("Bernd", "Harrer", "zorro@gmail.com", 50));
            ListCustomer.Add(new Customer("Arnold", "Mair", "M.Arnold@gmail.com", 30));
            ListCustomer.Add(new Customer("Bernhard", "Mair", "asdro@gmail.com", 10));     
        }

        [TestMethod]
        public void ValidNames()
        {
            //arrange
            string[] validNames = { "Jürgen", "Alex", "Bo"};
            FormAdd_Edit formAE = new FormAdd_Edit(ListCustomer);
            bool namesOK = true;

            //act
            foreach (string name in validNames)
            {
                if (!formAE.checkName(name))
                {
                    namesOK = false;
                    break;
                }
            }

            // assert
            Assert.IsTrue(namesOK);
        }

        [TestMethod]
        public void InValidNames()
        {
            //arrange
            string[] inValidnames = { "jürgen", "a", "al", "Jürg3n", "§lex", "JÜRGEN", "jÜRGEN"," ","" };
            FormAdd_Edit formAE = new FormAdd_Edit(ListCustomer);
            bool namesOK = false;

            //act
            foreach (string name in inValidnames)
            {
                if (formAE.checkName(name))
                {
                    namesOK = true;
                    break;
                }
            }

            // assert
            Assert.IsFalse(namesOK);
        }

        [TestMethod]
        public void ValidFilterFirstName()
        {
            // arrange           
            string stringFilter = "Bern";
            string filterBy = "First Name";
            List<int> IDListFilteredactual = new List<int>() { 2, 4 };

            // act
            List<int> IDListFiltered = CustomerData_SlowCookers.formMain.CreateFilteredIDList(ListCustomer, stringFilter, filterBy);

            // assert
            Assert.IsTrue(Enumerable.SequenceEqual(IDListFilteredactual, IDListFiltered));
            
        }

        [TestMethod]
        public void ValidFilterLastName()
        {
            // arrange
            string stringFilter = "Ma";
            string filterBy = "Last Name";
            List<int> IDListFilteredactual = new List<int>() { 3, 4 };

            // act
            List<int> IDListFiltered = CustomerData_SlowCookers.formMain.CreateFilteredIDList(ListCustomer, stringFilter, filterBy);

            // assert
            Assert.IsTrue(Enumerable.SequenceEqual(IDListFilteredactual, IDListFiltered));

        }
    }
}
