using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                if(checkName(value))
                {
                    this.firstName = value;
                }
                else
                {
                    string nameType = "first name";
                    throw new System.FormatException("The " + nameType + " only allows characters, the first needs to be big, the others small. Lenght needs to be at least 2");
                }
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
                if (checkName(value))
                {
                    this.lastName = value;
                }
                else
                {
                    string nameType = "last name";
                    throw new System.FormatException("The " + nameType + " only allows characters, the first needs to be big, the others small. Lenght needs to be at least 2");
                }
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
                if (eMailOK(value))
                {
                    this.email = value;
                }
                else
                {
                    throw new System.FormatException("The Email address only allows characters, numbers and this special symbols(!#$%&'*+-/=?^_`{|}~) in front of the @ sign, after the @ sign characters, numbers and special symbols are allowed. A dot is allowed after the @ sign and one char.");
                }
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
        public static bool checkName(string name)
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
        public static bool eMailOK(String email)
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
        #endregion
    }
}
