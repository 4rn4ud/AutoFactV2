using AutoFact2.Repository;
using AutoFact2.Views;
using AutoFact2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AutoFact2.Controllers
{
    public class InvoiceLineController
    {
        public InvoiceLineRepository InRepository;
        public InvoiceLineController()
        {
            InRepository = new InvoiceLineRepository();
        }

        //public List<Invoiceline> findAll()
        //{
        //    return InRepository.findAll(id);
        //}
        public void create(int idCustomer, DateTime DateInvoiceLine)
        {
            InRepository.create(idCustomer, DateInvoiceLine);
        }

        //public void delete(int id)
        //{
        //    InRepository.delete(id);
        //}

        public void update(int id, int idCustomer, DateTime DateInvoiceLine)
        {
            InRepository.update(id, idCustomer, DateInvoiceLine);
        }


    }
}
