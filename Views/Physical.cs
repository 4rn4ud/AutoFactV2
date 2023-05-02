using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact2.Views
{
    class Physical:Customer
    {
        private string _name;
        private string _lastname;

        public Physical(int id, string name, string lastname, string address, string postalCode, string city, string mail, string tel) : base(id, address, postalCode, city, mail, tel)
        {
            this._name = name;
            this._lastname = lastname;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string value)
        {
            this._name = value;
        }

        public string GetLastname()
        {
            return _lastname;
        }

        public void SetLastname(string value)
        {
            this._lastname = value;
        }
    }
}
