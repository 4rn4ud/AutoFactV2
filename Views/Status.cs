using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact2.Views
{
    class Status
    {
        private int _idQuote;
        private int _idType;
        private string _libel;
        private DateTime _date;

        public Status(int idQuote, int idType, string libel, DateTime date)
        {
            this._idQuote = idQuote;
            this._idType = idType;
            this._libel = libel;
            this._date = date;
        }

        public int GetIdQuote()
        {
            return _idQuote;
        }

        public void SetIdQuote(int value)
        {
            this._idQuote = value;
        }

        public int GetIdType()
        {
            return _idType;
        }

        public void SetIdType(int value)
        {
            this._idType = value;
        }

        public string GetLibel()
        {
            return _libel;
        }

        public void SetLibel(string value)
        {
            this._libel = value;
        }

        public DateTime GetDate()
        {
            return _date;
        }

        public void SetDate(DateTime value)
        {
            this._date = value;
        }
    }
}
