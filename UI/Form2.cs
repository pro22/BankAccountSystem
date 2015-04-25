using BO;
using Eutility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        BankBO bo = new BankBO();
        int index = 0;
        
        private void enterButton_Click(object sender, EventArgs e)
        {

            try
            {
                List<BankAccount> b = bo.getData();
                for (int i = 0; i < b.Count; i++)
                {
                    if ((accBox.Text).Equals(b[i].accountNumber))
                    {
                        nameBox.Text = b[i].name;
                        branchBox.Text = b[i].branch;
                        balanceBox.Text = Convert.ToString(b[i].balance);
                        //adrBox.Text = b[i].address;
                        depositBox.Text = null;
                        index = i;
                    }
                }
            }
            catch(Exception )
            {

            }
        }
    

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            List<BankAccount> b = bo.getData();
            try
            {
                b[index].name = nameBox.Text;
                b[index].branch = branchBox.Text;
                b[index].balance += Convert.ToInt32(depositBox.Text);
                balanceBox.Text = Convert.ToString(b[index].balance);
                //b[index].address = adrBox.Text;
                depositBox.Clear();
            }
            catch(Exception)
            {
               
            }
            if (bo.saveUpdatedData(b))
                upInfo.Text = "Updated Successfully.";
            else
                failInfo.Text = "Failed";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void accBox_TextChanged(object sender, EventArgs e)
        {

           

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void depositBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
