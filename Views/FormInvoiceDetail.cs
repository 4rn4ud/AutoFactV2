using AutoFact2.Controllers;
using AutoFact2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoFact2.Views
{
    public partial class FormInvoiceDetail : Form
    {
        public InvoiceController InController;
        public InvoiceLineController InlineController;
        private Invoice lafacture;

        public FormInvoiceDetail(int id)
        {
            InitializeComponent();
            InController = new InvoiceController();
            InlineController = new InvoiceLineController();
            lafacture = new Invoice(id);
            TxtDate.Text = Convert.ToString(lafacture.GetDateInvoice());
            TxtIdCustomer.Text = Convert.ToString(lafacture.GetidCustomer());
            TxtId.Text = Convert.ToString(id);
            LeRefresh(id);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvInvoiceline_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LeRefresh(int id)
        {
            this.DgvInvoiceline.Rows.Clear();
            foreach (Invoiceline Unelignefacture in InlineController.findAll(id))
            {
                string dgvIdQuote = Unelignefacture.GetIdQuote().ToString();
                string dgvIdProduct = Unelignefacture.GetIdProduct().ToString();
                string dgvQuantity = Unelignefacture.GetQuantity().ToString();
                string dgvPromotion = Unelignefacture.GetPromotion().ToString();
                string dgvPrice = Unelignefacture.GetPrice().ToString();
                string dgvAmount = Unelignefacture.GetAmount().ToString();

                this.DgvInvoiceline.Rows.Add(dgvIdQuote, dgvIdProduct, dgvQuantity, dgvPromotion, dgvPrice, dgvAmount);
            }
        }
    }
}