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
        private float _unitPrice;
        private int _idCategory;

        public Product(int id, string libel, float unitPrice, int idCategory)
        {
            this._id = id;
            this._libel = libel;
            this._unitPrice = unitPrice;
            this._idCategory = idCategory;
        }

        public int GetId()
        {
            return _id;
        }

        public void SetId(int value)
        {
            this._id = value;
        }

        public string GetLibel()
        {
            return _libel;
        }

        public void SetLibel(string value)
        {
            this._libel = value;
        }

        public float GetUnitPrice()
        {
            return _unitPrice;
        }

        public void SetUnitPrice(float value)
        {
            this._unitPrice = value;
        }

        public int GetIdCategory()
        {
            return _idCategory;
        }

        public void SetIdCategory(int value)
        {
            this._idCategory = value;
        }
    }
}
