using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact2.Views
{
    public class Invoiceline
    {
        private int _idQuote;
        private int _idProduct;
        private int _quantity;
        private decimal _promotion;
        private decimal _Price;

        public Invoiceline(int idQuote, int idProduct, int quantity, decimal promotion, decimal Price)
        {
            this._idQuote = idQuote;
            this._idProduct = idProduct;
            this._quantity = quantity;
            this._promotion = promotion;
            this._Price = Price;
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

        public decimal GetPromotion()
        {
            return _promotion;
        }

        public void SetPromotion(decimal promotion)
        {
            this._promotion = promotion;
        }

        public decimal GetPrice()
        {
            return this._Price;
        }

        public decimal GetAmount()
        {
            return this._Price * this._quantity;
        }


    }
}
