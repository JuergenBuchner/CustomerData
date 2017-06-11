using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData_SlowCookers
{
    public class Customer
    {
        public static int idCount = 1;
        #region Constructor
        public Customer(string firstName, string lastName, string email, decimal balance)
        {
            this.ID = idCount;
            idCount++;
            this.FirstName = firstName;
            LastName = lastName;
            eMail = email;
            Balance = balance;
        }
        #endregion Constructor
        #region Membervariables
        private int id;
        private string firstName;
        private string lastName;
        private string email;
        private decimal balance;
        #endregion Membervariables

        #region Properties
        public int ID
        {
            get
            {
                return this.id;
            }
            private set
            {
                this.id = value;
            }
        }
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }
        public string eMail
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }
        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            private set
            {
                this.balance = value;
            }
        }
        #endregion Properties
        #region MemberMethods
        public void addMoney(decimal additionalMoney)
        {
            this.Balance += additionalMoney;
        }
        #endregion
    }
}
