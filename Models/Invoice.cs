using AutoFact2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact2.Models
{
    internal class Invoice
    {
       
        private int _id;
        private string _idCustomer;
        private DateTime _DateInvoice;
        private List<Invoiceline> _Invoiceline;
        private decimal _Total;

        public Invoice(int id, string idCustomer, DateTime DateInvoice )
        {
            this._id = id;
            this._idCustomer = idCustomer;
            this._DateInvoice = DateInvoice;
            this._Invoiceline = new List<Invoiceline>();
            

        }

        public int GetId()
        {
            return _id;
        }

        public void SetId(int value)
        {
            this._id = value;
        }

        public string GetidCustomer()
        {
            return _idCustomer;
        }

        public void SetIdCustomer(string value)
        {
            this._idCustomer = value;
        }

        public DateTime GetDateInvoice()
        {
            return _DateInvoice;
        }

        public void SetDateInvoice(DateTime value)
        {
            this._DateInvoice = value;
        }



        public List<Invoiceline> GetInvoiceline()
        {
            return _Invoiceline;
        }        
        
        public decimal GetTotal()
        {
            Decimal Total = 0;
            foreach (Invoiceline line in _Invoiceline)
            {
                Total = Total + line.GetAmount();
            }
            return Total;
        }
    }
}
