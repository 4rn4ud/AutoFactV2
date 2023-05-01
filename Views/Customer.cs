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
        private string _name;
        private string _lastName;
        private string _companyName;
        private string _address;
        private string _postalCode;
        private string _city;
        private string _mail;
        private string _tel;

        public Customer(int id, string name, string lastName, string companyName, string address, string postalCode, string city, string mail, string tel)
        {
            this._id = id;
            this._name = name;
            this._lastName = lastName;
            this._companyName = companyName;
            this._address = address;
            this._postalCode = postalCode;
            this._city = city;
            this._mail = mail;
            this._tel = tel;
        }

        public int GetId()
        {
            return _id;
        }

        public void SetId(int value)
        {
            _id = value;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string value)
        {
            _name = value;
        }

        public string GetLastName()
        {
            return _lastName;
        }

        public void SetLastName(string value)
        {
            _lastName = value;
        }

        public string GetCompanyName()
        {
            return _companyName;
        }

        public void SetCompanyName(string value)
        {
            _companyName = value;
        }

        public string GetAddress()
        {
            return _address;
        }

        public void SetAddress(string value)
        {
            _address = value;
        }

        public string GetPostalCode()
        {
            return _postalCode;
        }

        public void SetPostalCode(string value)
        {
            _postalCode = value;
        }

        public string GetCity()
        {
            return _city;
        }

        public void SetCity(string value)
        {
            _city = value;
        }

        public string GetMail()
        {
            return _mail;
        }

        public void SetMail(string value)
        {
            _mail = value;
        }

        public string GetTel()
        {
            return _tel;
        }

        public void SetTel(string value)
        {
            _tel = value;
        }
    }
}
