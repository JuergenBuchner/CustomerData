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
        private CustomerList ListCustomer;

        [TestInitialize()]
        public void Initialize()
        {
            ListCustomer = new CustomerList();
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
            bool namesOK = true;

            //act
            foreach (string name in validNames)
            {
                if (!Customer.checkName(name))
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
            bool namesOK = false;

            //act
            foreach (string name in inValidnames)
            {
                if (Customer.checkName(name))
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
            List<int> IDListFilteredactual = new List<int>() { 2, 4 };

            // act
            List<int> IDListFiltered = CustomerData_SlowCookers.formMain.CreateFilteredIDList(ListCustomer, stringFilter, 0);

            // assert
            Assert.IsTrue(Enumerable.SequenceEqual(IDListFilteredactual, IDListFiltered));
            
        }

        [TestMethod]
        public void ValidFilterLastName()
        {
            // arrange
            string stringFilter = "Ma";
            List<int> IDListFilteredactual = new List<int>() { 3, 4 };

            // act
            List<int> IDListFiltered = CustomerData_SlowCookers.formMain.CreateFilteredIDList(ListCustomer, stringFilter, 1);

            // assert
            Assert.IsTrue(Enumerable.SequenceEqual(IDListFilteredactual, IDListFiltered));

        }
    }
}
