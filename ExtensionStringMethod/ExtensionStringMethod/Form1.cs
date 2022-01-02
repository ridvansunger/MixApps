using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExtensionStringMethod.CustomExtensions;

namespace ExtensionStringMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = txtYazi.Text;
            if (metin.ContainsText(txtContains.Text))
            {
                MessageBox.Show("içerir.");
            }
            else
            {
                MessageBox.Show("içermez");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string metin = txtYazi.Text;
            if(metin.StartWithText(txtStartWith.Text))
            {
                MessageBox.Show("başlar");
            }
            else
            {
                MessageBox.Show("Başlamaz");
            }
        }
    }
}
