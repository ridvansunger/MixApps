using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form1 form1 { get; set; }

        List<Tuple<string, string, string, PictureBox>> customerList = new List<Tuple<string, string, string, PictureBox>>();
       //customerlist in içinde
       //     1. ad soyad
       //     2. tc
       //     3. cinsiyet
       //     4. tıklanan koltuk bilgisi

       
        private void btnOnay_Click(object sender, EventArgs e)
        {
           
            //form1 den form2 ye gectik, onayla butonu burada koltuk değişikliği yapacak.
            form1.KoltuguDoldur();

            string customerName = txtAdSoyad.Text;
            string customerTC = txtTc.Text;
            string customerCinsiyet = "";
            if (rbBay.Checked)
            {
                customerCinsiyet = "Bay";
            }
            if (rbBayan.Checked)
            {
                customerCinsiyet = "Bayan";
            }

            PictureBox form2yeGelenKoltuk= form1.secilenKoltuk;

            Tuple<string, string, string, PictureBox> kisiBilgisi = Tuple.Create(customerName, customerTC, customerCinsiyet, form2yeGelenKoltuk);

            customerList.Add(kisiBilgisi);
           


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        
    }
}
