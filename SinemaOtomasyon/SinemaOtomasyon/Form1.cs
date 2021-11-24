using SinemaOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public PictureBox secilenKoltuk;


        public string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        CustomerRepository customerRepository;

        private void Form1_Load(object sender, EventArgs e)
        {
            FillKoltuk();
            customerRepository = new CustomerRepository();


        }

        

        private void FillKoltuk()
        {
            for (int i = 0; i < 78; i++)
            {
                PictureBox pbox = new PictureBox();
                //pbox.BackColor = Color.Green;
                pbox.SizeMode = PictureBoxSizeMode.StretchImage;
                pbox.Image= Image.FromFile($"{path}\\resim\\boş.png");
                pbox.Click += Pbox_Click;

                pbox.Width = 50;
                pbox.Height = 50;
                

                flowLayoutPanel1.Controls.Add(pbox);


            }
        }

        private void Pbox_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();//yeni bir form2 türettik
            secilenKoltuk = sender as PictureBox;//secilen pbox bilgisi secilen koltuğa atandı
            form2.form1 = this;//form 2 üzerindeki form1 değişkenine(this (bu form)) bu atadık.
            form2.ShowDialog();
        }

        public void KoltuguDoldur()
        {
            //MessageBox.Show("Koltuk doldu");
            
            secilenKoltuk.Image= Image.FromFile($"{path}\\resim\\Dolu.png");



        }

        
        
    }
}
