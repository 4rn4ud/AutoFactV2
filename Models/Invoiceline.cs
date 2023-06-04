using System;

namespace AutoFact2.Views
{
    public class Invoiceline
    {
        private int _idInvoice;
        private int _idProduct;
        private int _quantity;
        private decimal _promotion;
        private decimal _price;
        private int _id;

        public Invoiceline(int idInvoice, int idProduct, int quantity, decimal promotion, decimal price)
        {
            this._idInvoice = idInvoice;
            this._idProduct = idProduct;
            this._quantity = quantity;
            this._promotion = promotion;
            this._price = price;
            
        }

        public int GetIdInvoice()
        {
            return _idInvoice;
        }

        public void SetIdInvoice(int idInvoice)
        {
            this._idInvoice = idInvoice;
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
            return this._price;
        }

        public decimal GetAmount()
        {
            return this._price * this._quantity;
        }

        public int GetId()
        {
            return this._id;
        }

    }
}