using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cashtransactions
{
    public partial class Form1 : Form
    {
        guy Joe;
        guy Bob;
        int bank = 100;

        public Form1()
        {
            InitializeComponent();
            //Slow method (not so good)
            /*
            Bob = new guy();
            Bob.Name = "Bob";
            Bob.Cash = 100;

            Joe = new guy();
            Joe.Name = "Joe";
            Joe.Cash = 50;
            */

            //Example of object initializer
            Joe = new guy() { Cash = 50, Name = "Joe" };
            Bob = new guy() { Cash = 100, Name = "Bob" };

            UpdateForm();

        }

        public void UpdateForm()
        {
            joesCashLabel.Text = Joe.Name + " has $" + Joe.Cash;
            bobsCashLabel.Text = Bob.Name + " has $" + Bob.Cash;
            bankLabel.Text = "The bank has $" + bank;
        }

        private void buttonGiveJoe_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= Joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("The bank is out of money.");
            }
        }

        private void buttonReceiveFromBob_Click(object sender, EventArgs e)
        {
            bank += Bob.GiveCash(5);
            UpdateForm();
        }

        private void buttonGiveToBob_Click(object sender, EventArgs e)
        {
            Bob.ReceiveCash(Joe.GiveCash(10));
            UpdateForm();
        }

        private void buttonBobGiveToJoe_Click(object sender, EventArgs e)
        {
            Joe.ReceiveCash(Bob.GiveCash(5));
            UpdateForm();
        }
        
    }
}
