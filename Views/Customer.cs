using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact2.Views
{
    class Customer
    {
        private int id;
        private string name;
        private string lastName;
        private string companyName;
        private string address;
        private string postalCode;
        private string city;
        private string mail;
        private string tel;

        public Customer(int id, string name, string lastName, string companyName, string address, string postalCode, string city, string mail, string tel)
        {
            this.id = id;
            this.name = name;
            this.lastName = lastName;
            this.companyName = companyName;
            this.address = address;
            this.postalCode = postalCode;
            this.city = city;
            this.mail = mail;
            this.tel = tel;
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int value)
        {
            id = value;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public void SetLastName(string value)
        {
            lastName = value;
        }

        public string GetCompanyName()
        {
            return companyName;
        }

        public void SetCompanyName(string value)
        {
            companyName = value;
        }

        public string GetAddress()
        {
            return address;
        }

        public void SetAddress(string value)
        {
            address = value;
        }

        public string GetPostalCode()
        {
            return postalCode;
        }

        public void SetPostalCode(string value)
        {
            postalCode = value;
        }

        public string GetCity()
        {
            return city;
        }

        public void SetCity(string value)
        {
            city = value;
        }

        public string GetMail()
        {
            return mail;
        }

        public void SetMail(string value)
        {
            mail = value;
        }

        public string GetTel()
        {
            return tel;
        }

        public void SetTel(string value)
        {
            tel = value;
        }
    }
}
