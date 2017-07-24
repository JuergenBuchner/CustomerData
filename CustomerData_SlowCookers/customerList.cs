using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData_SlowCookers
{
    public class CustomerList : List<Customer>
    {
        #region Constructors
        public CustomerList()
        {
            idCount = 1;
        }
        #endregion Constructors
        #region MemberVariables
        int idCount;
        #endregion MemberVariables
        #region Properties
        #endregion Properties
        #region override
        public new void Add(Customer item)
        {
            base.Add(item);

            this.Last().ID = idCount;
            idCount++;
        }
        /// <summary>
        /// Replacing the items in the current customerList by assuming that the IDs of the list items are correct/unique.
        /// </summary>
        /// <param name="list"></param>
        public void ReplaceByIndexedList(List<Customer> list)
        {
            this.Clear();
            base.AddRange(list);
            idCount = list.Count;
        }
        #endregion override
    }
}
