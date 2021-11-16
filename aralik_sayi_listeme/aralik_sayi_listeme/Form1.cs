using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aralik_sayi_listeme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);

            for (int i = sayi1; i <= sayi2; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void btnCiftYazdir_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            int sayi3 = Convert.ToInt32(txtSayi1.Text);
            int sayi4 = Convert.ToInt32(txtSayi2.Text);

            string cift = "Çift Sayılar:";
            listBox1.Items.Add(cift);

            for (int i = sayi3; i <=sayi4; i++)
            {
                

                if (i % 2 == 0)
                {
                    
                    listBox1.Items.Add(i);
                }

            }
            
               
            
        }
    }
}
