using SinemaOtomasyon.Entities;
using SinemaOtomasyon.FakeDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyon.DAL
{
    public class CustomerRepository
    {
        public void Add(Customer item)
        {
            item.customerID = (++CustomerDataBaseFakeDb.CustomerTableId);
            CustomerDataBaseFakeDb.custumerList.Add(item);
        }

        public Customer FindById(int id)
        {
            Customer customer = CustomerDataBaseFakeDb.custumerList.FirstOrDefault(c0 => c0.customerID == id);
            return customer;
        }

        public void Update(Customer item)
        {
            var dbItem= FindById(item.customerID);

            if(dbItem !=null)
            {
                dbItem.customerID = item.customerID;
                dbItem.customerName = item.customerName;
                dbItem.customerPhone = item.customerPhone;
                dbItem.customerSex = item.customerSex;
            }
        }


        public void Delete(int id)
        {
           var dbItem =FindById(id);
            if(dbItem !=null)
            {
                CustomerDataBaseFakeDb.custumerList.Remove(dbItem);
            }
        }

        public List<Customer> Get()
        {
            return CustomerDataBaseFakeDb.custumerList;
        }

        


    }
}
