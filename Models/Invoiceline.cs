using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact2.Views
{
    class Invoiceline
    {
        private int _idQuote;
        private int _idProduct;
        private int _quantity;
        private float _promotion;
        private List<Quote> _listQuote;
        private List<Product> _listProduct;

        public Invoiceline(int idQuote, int idProduct, int quantity, float promotion)
        {
            this._idQuote = idQuote;
            this._idProduct = idProduct;
            this._quantity = quantity;
            this._promotion = promotion;
            this._listQuote = new List<Quote>();
            this._listProduct = new List<Product>();
        }

        public int GetIdQuote()
        {
            return _idQuote;
        }

        public void SetIdQuote(int idQuote)
        {
            this._idQuote = idQuote;
        }

        public int GetIdProduct()
        {
            return _idProduct;
        }

        public void SetIdProduct(int idProduct)
        {
            this._idProduct = idProduct;
        }

        public int GetQuantity()
        {
            return _quantity;
        }

        public void SetQuantity(int quantity)
        {
            this._quantity = quantity;
        }

        public float GetPromotion()
        {
            return _promotion;
        }

        public void SetPromotion(float promotion)
        {
            this._promotion = promotion;
        }
    }
}
