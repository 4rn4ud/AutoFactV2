using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact2.Views
{
    class Customer
    {
        private int _id;
        private string _address;
        private string _postalCode;
        private string _city;
        private string _mail;
        private string _tel;
        private List<Quote> _listQuote;

        public Customer(int id, string address, string postalCode, string city, string mail, string tel)
        {
            this._id = id;
            this._address = address;
            this._postalCode = postalCode;
            this._city = city;
            this._mail = mail;
            this._tel = tel;
            this._listQuote = new List<Quote>();
        }

        public int GetId()
        {
            return _id;
        }

        public void SetId(int value)
        {
            this._id = value;
        }

        public string GetAddress()
        {
            return _address;
        }

        public void SetAddress(string value)
        {
            this._address = value;
        }

        public string GetPostalCode()
        {
            return _postalCode;
        }

        public void SetPostalCode(string value)
        {
            this._postalCode = value;
        }

        public string GetCity()
        {
            return _city;
        }

        public void SetCity(string value)
        {
            this._city = value;
        }

        public string GetMail()
        {
            return _mail;
        }

        public void SetMail(string value)
        {
            this._mail = value;
        }

        public string GetTel()
        {
            return _tel;
        }

        public void SetTel(string value)
        {
            this._tel = value;
        }

        public List<Quote> GetListQuote()
        {
            return _listQuote;
        }

        public void SetQuote(Quote quote)
        {
            this._listQuote.Add(quote);
        }
    }
}
