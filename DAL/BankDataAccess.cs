using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Eutility;

namespace DAL
{
    public class BankDataAccess
    {
        public bool savingData(BankAccount b)
        {
            try
            {
                StreamWriter w = new StreamWriter(@"H:\inp.txt", true);
                w.WriteLine(b.accountNumber);
                w.WriteLine(b.name);
                w.WriteLine(b.branch);
                w.WriteLine(b.balance);
                //w.WriteLine(b.address);
                w.Close();
                return true;
            }
            catch(Exception e1)
            {
                return false;
            }
        }

        public bool savingUpdatedData(List<BankAccount> b)
        {
            try
            {
                StreamWriter w = new StreamWriter(@"H:\inp.txt");
                for (int i = 0; i < b.Count; i++)
                {
                    w.WriteLine(b[i].accountNumber);
                    w.WriteLine(b[i].name);
                    w.WriteLine(b[i].branch);
                    w.WriteLine(b[i].balance);
                    w.WriteLine(b[i].address);
                }
                w.Close();
                return true;
            }
                
            catch(Exception e1)
            {
                return false;
            }
        }

        public List<BankAccount> getData()
        {
            List<BankAccount> bList = new List<BankAccount>();
            try
            {
                StreamReader r = new StreamReader(@"H:\inp.txt");
                string temp = r.ReadLine();
                while(temp != null)
                {
                    BankAccount b = new BankAccount();
                    b.accountNumber = temp;
                    b.name = r.ReadLine();
                   // b.address = r.ReadLine();
                    temp = b.branch = r.ReadLine();
                    temp = r.ReadLine();
                    b.balance = Convert.ToInt32(temp);
                    bList.Add(b);
                    temp = r.ReadLine();
                }
                r.Close();
                return bList;
            }
            catch(Exception e1)  
            {
                return null;
            }
        }
    }
}
