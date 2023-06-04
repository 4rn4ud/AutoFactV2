using AutoFact2.Repository;
using AutoFact2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact2.Controllers
{
    public class ProductController
    {
        public ProductRepository productRepository;
        public ProductController()
        {
            productRepository = new ProductRepository();
        }

        public List<Product> findAll()
        {
            return productRepository.findAll();
        }

        public void create(string label, float unitPrice, int idCategory)
        {
            productRepository.create(label, unitPrice, idCategory);
        }

        public void delete(int id)
        {
            productRepository.delete(id);
        }

        public void update(int id, string label, float unitPrice, int idCategory)
        {
            productRepository.update(id, label, unitPrice, idCategory);
        }
    }
}
