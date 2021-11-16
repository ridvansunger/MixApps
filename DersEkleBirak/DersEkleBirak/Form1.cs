using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DersEkleBirak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] dersler = { "Matematik", "Fizik", "Kimya", "Algoritma", "İşletim Sistemleri", "Örüntü Tanıma", "Database", "Mikro İşlemciler", "İngilizce", "Yapay Zeka", "Sınıflandırma", "Yazılım", "Tarih", "Edebiyat","Coğrafya","Müzik" };
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string ders in dersler)
            {
                lstDersler.Items.Add(ders);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //derslerden seçilen derslere aktarım yapacağiz.
            //listbox selection moddan birden fazla ders seçmek için multiSimple yapıyoruz.
            //listbox SelectedItems çoklu seçimde actığımız için buradan okuyacağız.

            foreach (string ders in lstDersler.SelectedItems)
            {
                //içinde arama yapmak için contain kullanıllır.
                if (!lstSecilenDersler.Items.Contains(ders)) 
                lstSecilenDersler.Items.Add(ders);
            }

            for (int i = 0; i < lstSecilenDersler.Items.Count; i++)
            {
                //IndexOf verilen collectionun içinde arama yapar eğer arama sonucunda bir şey bulur ise ilgili index döner.
                //Remove item ister RemoveAt index ister.
                string secilmisDers = lstSecilenDersler.Items[i] as string;
                int index = lstDersler.Items.IndexOf(secilmisDers);
                if (index > -1)
                    lstDersler.Items.RemoveAt(index);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (string ders in lstSecilenDersler.SelectedItems)
            {
                if (!lstDersler.Items.Contains(ders))
                    lstDersler.Items.Add(ders);
            }

            for (int i = 0; i < lstDersler.Items.Count; i++)
            {
                string dersAzalt = lstDersler.Items[i] as string;
                int index = lstSecilenDersler.Items.IndexOf(dersAzalt);
                if (index > -1)
                    lstSecilenDersler.Items.RemoveAt(index);

            }
        }
    }
}
