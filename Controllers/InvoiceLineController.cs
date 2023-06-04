using AutoFact2.Models;
using AutoFact2.Repository;
using AutoFact2.Views;
using System;
using System.Collections.Generic;

namespace AutoFact2.Controllers
{
    public class InvoiceLineController
    {
        public InvoiceLineRepository inLineRepository;

        public InvoiceLineController()
        {
            inLineRepository = new InvoiceLineRepository();
        }

        public List<Invoiceline> FindAll(int invoiceId)
        {
            return inLineRepository.FindAll(invoiceId);
        }

        public int Create(int invoiceId, int productId, int quantity, decimal price, decimal promotion)
        {
            Invoiceline invoiceLine = new Invoiceline(invoiceId, productId, quantity, promotion, price);
            int id = inLineRepository.Create(invoiceLine);

            return id;
        }

        public void Create(Invoiceline invoiceLine)
        {
            int id = inLineRepository.Create(invoiceLine);
            invoiceLine.SetId(id);
        }

        public void Update(int id, int invoiceId, int productId, int quantity, decimal price, decimal promotion)
        {
            Invoiceline invoiceLine = new Invoiceline(invoiceId, productId, quantity, promotion, price);
            inLineRepository.Update(invoiceLine);
        }

        public void Delete(int invoiceId)
        {
            inLineRepository.Delete(invoiceId);
        }
    }
}