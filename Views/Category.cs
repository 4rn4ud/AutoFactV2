﻿using System.Collections.Generic;

namespace AutoFact2.Views
{
    class Category
    {
        private int _id;
        private string _libel;
        private List<Product> _listProduct;

        public Category(int id, string libel)
        {
            this._id = id;
            this._libel = libel;
            this._listProduct = new List<Product>();
        }

        public void SetId(int id)
        {
            this._id = id;
        }

        public int GetId()
        {
            return _id;
        }

        public void SetLibel(string libel)
        {
            this._libel = libel;
        }

        public string GetLibel()
        {
            return _libel;
        }

        public List<Product> GetListProduct()
        {
            return _listProduct;
        }

        public void SetProduct(Product product)
        {
            this._listProduct.Add(product);
        }
    }
}
