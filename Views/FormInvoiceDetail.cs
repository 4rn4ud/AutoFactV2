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
            // Check if the clicked cell is the "Delete" button
            if (e.ColumnIndex == DgvInvoiceline.Columns["BtnColDelete"].Index && e.RowIndex >= 0)
            {
                // Get the corresponding invoice line and its ID
                Invoiceline invoiceLine = InlineController.FindAll(lafacture.GetId())[e.RowIndex];
                int invoiceLineId = invoiceLine.GetId();

                // Delete the invoice line
                InlineController.Delete(invoiceLineId);

                // Refresh the DataGridView
                LeRefresh(lafacture.GetId());
            }
            // Check if the clicked cell is the "Update" button
            else if (e.ColumnIndex == DgvInvoiceline.Columns["BtnColUpdate"].Index && e.RowIndex >= 0)
            {
                // Get the corresponding invoice line and its ID
                Invoiceline invoiceLine = InlineController.FindAll(lafacture.GetId())[e.RowIndex];
                int invoiceLineId = invoiceLine.GetId();

                // Open the update form with the invoice line ID as a parameter
                FormInvoiceLineUpdate updateInvoiceLine = new FormInvoiceLineUpdate(invoiceLineId);
                updateInvoiceLine.ShowDialog();

                // Refresh the DataGridView
                LeRefresh(lafacture.GetId());
            }
        }

        public void LeRefresh(int id)
        {
            this.DgvInvoiceline.Rows.Clear();
            ProductController productController = new ProductController();

            foreach (Invoiceline invoiceLine in InlineController.FindAll(id))
            {
                Product product = productController.Find(invoiceLine.GetIdProduct());

                string dgvIdProduct = product.GetLabel();
                string dgvQuantity = invoiceLine.GetQuantity().ToString();
                string dgvPromotion = invoiceLine.GetPromotion().ToString();
                string dgvPrice = invoiceLine.GetPrice().ToString();
                string dgvAmount = invoiceLine.GetAmount().ToString();

                this.DgvInvoiceline.Rows.Add(dgvIdProduct, dgvQuantity, dgvPromotion, dgvPrice, dgvAmount, "Supprimer", "Modifier");
            }
        }

        private void BtnCreateInvoiceLine_Click(object sender, EventArgs e)
        {
            FormInvoiceLineCreate CreateInvoiceLine = new FormInvoiceLineCreate(lafacture.GetId());
            CreateInvoiceLine.ShowDialog();

            // Refresh the DataGridView
            LeRefresh(lafacture.GetId());
        }
    }
}