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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if(accBox.Text==""||
                   nameBox.Text==""||
                   branchBox.Text==""||
                   balanceBox.Text==""||
                   adrBox.Text==""
                )
            {
                MessageBox.Show("Input Perfectly");
            }
            else
            {
                BankAccount ba = new BankAccount();
                BankBO bo = new BankBO();
                try
                {
                    if (Convert.ToDouble(balanceBox.Text) < 500.00)
                    {
                        info.Text = "At Least 500 taka";
                    }
                    else
                    {
                        ba.accountNumber = accBox.Text;
                        ba.name = nameBox.Text;
                        ba.branch = branchBox.Text;
                        ba.balance = Convert.ToInt32(balanceBox.Text);
                        ba.address = adrBox.Text;
                        if (bo.saveData(ba))
                        {
                            accInfo.Text = "Account Created Successfully.";
                        }
                        else
                        {
                            accInfo.Text = "Failed. Please enter all data correctly.";
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Can't take String as balance");
                }
            
            }
            
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            accBox.Clear();
            nameBox.Clear();
           
            accInfo.Text = null;
            balanceBox.Clear();
            adrBox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void balanceBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
