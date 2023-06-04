using AutoFact2.Controllers;
using AutoFact2.Models;
using AutoFact2.Repository;
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
            TxtDate.Text = lafacture.GetDateInvoice().ToShortDateString();
            TxtIdCustomer.Text = Convert.ToString(lafacture.GetidCustomer());
            TxtId.Text = Convert.ToString(id);

            CustomerRepository custRepository = new CustomerRepository();
            Customer customerrepo = custRepository.getInfo(lafacture.GetidCustomer());
            //MessageBox.Show(Convert.ToString(lafacture.GetidCustomer()));
            TxtName.Text = customerrepo.GetName();
            TxtSurname.Text = customerrepo.GetLastname();
            TxtCompagnyName.Text = customerrepo.GetCompanyName();

            TxtTotal.Text = lafacture.GetTotal().ToString();

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
            foreach (Invoiceline Unelignefacture in InlineController.FindAll(id))
            {
                string dgvIdInvoice = Unelignefacture.GetIdInvoice().ToString();
                string dgvIdProduct = Unelignefacture.GetIdProduct().ToString();
                string dgvQuantity = Unelignefacture.GetQuantity().ToString();
                string dgvPromotion = Unelignefacture.GetPromotion().ToString();
                string dgvPrice = Unelignefacture.GetPrice().ToString();
                string dgvAmount = Unelignefacture.GetAmount().ToString();

                this.DgvInvoiceline.Rows.Add(dgvIdInvoice, dgvIdProduct, dgvQuantity, dgvPromotion, dgvPrice, dgvAmount);
            }
        }

        private void BtnCreateInvoiceLine_Click(object sender, EventArgs e)
        {
            FormInvoiceLineCreate CreateInvoiceLine = new FormInvoiceLineCreate(lafacture.GetId());
            CreateInvoiceLine.ShowDialog();
        }
    }
}