using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kruskal
{
    public partial class Cost : Form
    {
        public int nCost;

        public Cost()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (textBox.Text == string.Empty)
                
                MessageBox.Show(textBox, "please enter value");
            else
            {
                nCost = int.Parse(textBox.Text);
                this.Close();
            }

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8) 
                return;
            if (e.KeyChar < '0' || e.KeyChar > '9') 
                e.Handled = true;
        }
    }
}
