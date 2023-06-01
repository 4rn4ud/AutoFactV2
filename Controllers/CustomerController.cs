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
    }
}
