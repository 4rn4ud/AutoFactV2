using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact2.Views
{
    class Category
    {
        private int id;
        private string libel;
        private List<Product> listeProduct;

        public Category(int id, string libel)
        {
            this.id = id;
            this.libel = libel;
            this.listeProduct = new List<Product>() ;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }

        public void SetLibel(string libel)
        {
            this.libel = libel;
        }

        public string GetLibel()
        {
            return libel;
        }

        public List<Product> GetListeProduct()
        {
            return listeProduct;
        }

        public void SetProduct(Product product)
        {
            listeProduct.Add(product);
        }
    }

}
