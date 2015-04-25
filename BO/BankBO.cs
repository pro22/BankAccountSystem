using DAL;
using Eutility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BO
{
    public class BankBO
    {
        BankDataAccess bda = new BankDataAccess();
        /*int index;
        public string updateBalance(string deposit)
        {
            List<BankAccount> b = bda.getData();
            b[index].balance += Convert.ToInt32(depositBox.Text);
            string s=Convert.ToString(b[index].balance);
            
        }*/
        public bool saveData(BankAccount ba)
        {
            return bda.savingData(ba);
        }

        public bool saveUpdatedData(List<BankAccount> b)
        {
            return bda.savingUpdatedData(b);
        }

        public List<BankAccount> getData()
        {
            return bda.getData();
        }
    }
}
