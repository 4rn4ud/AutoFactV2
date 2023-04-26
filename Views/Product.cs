using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact2.Views
{
    class Product
    {
        private int _id;
        private string _libel;
        private double _unitPrice;
        private int _idCategory;

        public int GetId()
        {
            return _id;
        }

        public void SetId(int value)
        {
            _id = value;
        }

        public string GetLibel()
        {
            return _libel;
        }

        public void SetLibel(string value)
        {
            _libel = value;
        }

        public double GetUnitPrice()
        {
            return _unitPrice;
        }

        public void SetUnitPrice(double value)
        {
            _unitPrice = value;
        }

        public int GetIdCategory()
        {
            return _idCategory;
        }

        public void SetIdCategory(int value)
        {
            _idCategory = value;
        }

        public Product(int id, string libel, double unitPrice, int idCategory)
        {
            _id = id;
            _libel = libel;
            _unitPrice = unitPrice;
            _idCategory = idCategory;
        }
    }
}
