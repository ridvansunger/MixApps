using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radio_ile_Dort_islem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double sonuc=1;
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);

            if (rdbTopla.Checked)
            {
                sonuc = sayi1 + sayi2;
            }
            else if (rdbCikar.Checked)
            {
                sonuc = sayi1 - sayi2;
            }
            else if (rdbCarp.Checked)
            {
                sonuc = sayi1 * sayi2;
            }
            else if (rdbBol.Checked)
            {
                sonuc = sayi1 / sayi2;
            }


            lblSonuc.Text = "Sonuc:" + sonuc;
           
        }
    }
}
