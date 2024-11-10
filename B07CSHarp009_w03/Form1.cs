using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B07CSHarp009_w03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse( this.txtnumber.Text);
            if (number % 2 == 0)
            {
                this.lblresult.Text = $"{number} is even";
            }
            else
            {
                this.lblresult.Text = $"{number} is odd";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to our store");
        }
    }
}
