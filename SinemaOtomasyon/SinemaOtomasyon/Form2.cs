using SinemaOtomasyon.Core;
using SinemaOtomasyon.DAL;
using SinemaOtomasyon.Entities;
using SinemaOtomasyon.Helper;
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

        // List<Tuple<string, string, string, PictureBox>> customerList = new List<Tuple<string, string, string, PictureBox>>();
        ////customerlist in içinde
        ////     1. ad soyad
        ////     2. tc
        ////     3. cinsiyet
        ////     4. tıklanan koltuk bilgisi


        CustomerRepository customerRepository;
        

        private void Form2_Load(object sender, EventArgs e)
        {
            customerRepository = new CustomerRepository();

            FillData();
            if (form1.secilenKoltuk.Tag != null)
            {
                int kisiId = Convert.ToInt32(form1.secilenKoltuk.Tag);

                KisiBilgileriniGetir(kisiId);
            }
        }

        public void FillData()
        {
            int id = Convert.ToInt32(this.Tag);

            try
            {
                if (id > 0)
                {
                    Customer customer = customerRepository.FindById(id);
                    if (customer != null)
                    {
                        txtAdSoyad.Text = customer.customerName;
                        txtPhone.Text = customer.customerPhone;
                        //customer.customerSex("Bay"?rbBay.Checked:rbBayan.Checked);

                        if (customer.customerSex == "Bay")
                            rbBay.Checked = true;
                        else
                            rbBayan.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {

                Utility.ShowErrorMessage(ex.Message);
            }
        }

        private void KisiBilgileriniGetir(int kisiID)
        {
            var customer = customerRepository.FindById(kisiID);
            txtAdSoyad.Text = customer.customerName;
            txtPhone.Text = customer.customerPhone;
            //customer.customerSex("Bay"?rbBay.Checked:rbBayan.Checked);

            if (customer.customerSex == "Bay")
                rbBay.Checked = true;
            else
                rbBayan.Checked = true;
        }
        private void btnOnay_Click(object sender, EventArgs e)
        {

            ////form1 den form2 ye gectik, onayla butonu burada koltuk değişikliği yapacak.
            //form1.KoltuguDoldur();

            //string customerName = txtAdSoyad.Text;
            //string customerTC = txtPhone.Text;
            //string customerCinsiyet = "";
            //if (rbBay.Checked)
            //{
            //    customerCinsiyet = "Bay";
            //}
            //if (rbBayan.Checked)
            //{
            //    customerCinsiyet = "Bayan";
            //}



            //Tuple<string, string, string, PictureBox> kisiBilgisi = Tuple.Create(customerName, customerTC, customerCinsiyet, form2yeGelenKoltuk);

            //customerList.Add(kisiBilgisi);

            try
            {
                Customer customer = new Customer();
                customer.customerID = Convert.ToInt32(this.Tag);
                customer.customerName = txtAdSoyad.Text;
                customer.customerPhone = txtPhone.Text;

                if (rbBay.Checked)
                {
                    customer.customerSex = "Bay";
                }
                if (rbBayan.Checked)
                {
                    customer.customerSex = "Bayan";
                }

                if (customer.customerID == 0)
                {
                    customerRepository.Add(customer);
                    PictureBox form2yeGelenKoltuk = form1.secilenKoltuk;
                    form2yeGelenKoltuk.Tag = customer.customerID;
                    form2yeGelenKoltuk.Image = Image.FromFile($"{form1.path}\\resim\\Dolu.png");


                    Utility.ShowSuccessMessage("Kayıt başarılı");
                    this.Close();
                }
                else
                {
                    customerRepository.Update(customer);
                    this.Close();
                }




            }
            catch (Exception ex)
            {

                Utility.ShowErrorMessage(ex.Message);
            }




        }

        private void btnCancel_Click(object sender, EventArgs e)
        {


            try
            {
                if (txtAdSoyad.Text != "")
                {
                    DialogResult result = MessageBox.Show("silme işlemini onaylıyor musunuz?", "Onay Ekranı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(result==DialogResult.Yes)
                    {

                        form1.KoltuguBosalt();
                        RezervasyonuEkranTemizle();
                        

                    }
                }
            }
            catch (Exception ex)
            {

                Utility.ShowErrorMessage(ex.Message);
            }
        }


        public void RezervasyonuEkranTemizle()
        {
            txtAdSoyad.Text = "";
            txtPhone.Text = "";
            rbBay.Checked = false;
            rbBayan.Checked = false;
        }


    }
}
