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
    public partial class Analiz : Form
    {
        public Analiz()
        {
            InitializeComponent();
        }

        CustomerRepository customerRepository;
    

        private void Analiz_Load(object sender, EventArgs e)
        {
            customerRepository = new CustomerRepository();
            RefreshCustomer();
        }

        public void RefreshCustomer()
        {
            grdCustomer.DataSource = null;
            grdCustomer.DataSource = customerRepository.Get();
        }

        private void grdCustomer_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var customers = (grdCustomer.DataSource as List<Customer>);
               if(grdCustomer.SelectedRows.Count>0)
                {
                    var customer = customers[grdCustomer.SelectedRows[0].Index];

                    Form2 form2 = new Form2();
                    form2.Tag = customer.customerID;
                    form2.ShowDialog();
                    RefreshCustomer();
                }
            }
            catch (Exception ex)
            {

                Utility.ShowErrorMessage(ex.Message);
            }
        }
    }
}
