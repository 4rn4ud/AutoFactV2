using AutoFact2.Repository;
using AutoFact2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFact2.Controllers
{
    public class CustomerController
    {
        public CustomerRepository customerRepository;
        public CustomerController()
        {
            customerRepository = new CustomerRepository();
        }

        public List<Customer> findAll()
        {
            return customerRepository.findAll();
        }
<<<<<<< Updated upstream
=======
        public void create(string name, string lastName, string companyName, string address, int postalCode, string city, string mail, string tel)
        {
            customerRepository.create(name, lastName, companyName, address, postalCode, city, mail, tel);
        }

        public void delete(int id)
        {
            customerRepository.delete(id);
        }

        public void update(int id, string name, string lastName, string companyName, string address, int postalCode, string city, string mail, string tel)
        {
            customerRepository.update(id, name, lastName, companyName, address, postalCode, city, mail, tel);
        }

        public void RecupId(int id)
        {
            FormClientUpdate.RecupId(id);
        }
>>>>>>> Stashed changes
    }
}
