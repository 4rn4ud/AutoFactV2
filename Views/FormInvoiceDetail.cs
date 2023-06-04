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
        private CustomerRepository custRepository;

        public FormInvoiceDetail(int id)
        {
            InitializeComponent();
            InController = new InvoiceController();
            InlineController = new InvoiceLineController();
            lafacture = new Invoice(id);
            TxtDate.Text = lafacture.GetDateInvoice().ToShortDateString();
            //TxtIdCustomer.Text = Convert.ToString(lafacture.GetidCustomer());
            TxtId.Text = Convert.ToString(id);

            custRepository = new CustomerRepository();
            Customer customerrepo = custRepository.getInfo(lafacture.GetidCustomer());
            TxtName.Text = customerrepo.GetName();
            TxtSurname.Text = customerrepo.GetLastname();
            TxtCompagnyName.Text = customerrepo.GetCompanyName();

            TxtTotal.Text = lafacture.GetTotal().ToString();
            LoadCustomer(lafacture.GetidCustomer());
            CBCustomer.Enabled = false; // Désactive la ComboBox, la rendant non cliquable
            LeRefresh(id);
        }

        public FormInvoiceDetail()
        {
            InitializeComponent();
            InController = new InvoiceController();
            InlineController = new InvoiceLineController();
            lafacture = new Invoice();
            custRepository = new CustomerRepository();
            TxtDate.Text = DateTime.Now.ToShortDateString();
            // TxtId.Text = Convert.ToString(id);

            //custRepository = new CustomerRepository();
            //Customer customerrepo = custRepository.getInfo(lafacture.GetidCustomer());
            //TxtName.Text = customerrepo.GetName();
            //TxtSurname.Text = customerrepo.GetLastname();
            //TxtCompagnyName.Text = customerrepo.GetCompanyName();

            //TxtTotal.Text = lafacture.GetTotal().ToString();
            LoadCustomer();
            CBCustomer.Enabled = true; // Désactive la ComboBox, la rendant non cliquable
            //LeRefresh(id);
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

        private void LoadCustomer(int idcustomerselectionne)
        {
            List<Customer> customers = custRepository.findAll();
            CBCustomer.DisplayMember = "Text";
            CBCustomer.ValueMember = "Value";
            int i = 0;
            foreach (Customer thesustomer in customers)
            {
                CBCustomer.Items.Add(new { Text = thesustomer.GetName() + " " + thesustomer.GetLastname(), Value = thesustomer.GetId() });

                if (thesustomer.GetId() == idcustomerselectionne)
                {
                    CBCustomer.SelectedIndex = i;
                }
                i = i + 1;
            }
        }

        private void LoadCustomer()
        {
            List<Customer> customers = custRepository.findAll();
            CBCustomer.DisplayMember = "Text";
            CBCustomer.ValueMember = "Value";
            int i = 0;
            foreach (Customer thesustomer in customers)
            {
                CBCustomer.Items.Add(new { Text = thesustomer.GetName() + " " + thesustomer.GetLastname(), Value = thesustomer.GetId() });


            }
        }

        public void LeRefresh(int id)
        {
            this.DgvInvoiceline.Rows.Clear();
            ProductController productController = new ProductController();

            foreach (Invoiceline invoiceLine in InlineController.FindAll(id))
            {
                Product product = productController.Find(invoiceLine.GetIdProduct());
                //MessageBox.Show("ceci est le test :" + invoiceLine.GetIdProduct());
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

            if ( CBCustomer.SelectedItem != null) {
                if (lafacture.GetId() != 0)
                {

                    FormInvoiceLineCreate CreateInvoiceLine = new FormInvoiceLineCreate(lafacture.GetId());
                    CreateInvoiceLine.ShowDialog();
                    // Refresh the DataGridView
                    LeRefresh(lafacture.GetId());
                }
                else
                {
                    lafacture.SetIdCustomer(Convert.ToInt32((CBCustomer.SelectedItem as dynamic).Value));
                    lafacture.SetDateInvoice(lafacture.GetDateInvoice());
                    lafacture.Create();
                    //MessageBox.Show(Convert.ToString(lafacture.GetId()));
                    if (lafacture.GetId() != 0) { 
                    FormInvoiceLineCreate CreateInvoiceLine = new FormInvoiceLineCreate(lafacture.GetId());
                    CreateInvoiceLine.ShowDialog();
                    // Refresh the DataGridView
                    LeRefresh(lafacture.GetId());
                    }
                }

            }
            else
            {
                MessageBox.Show("Vous devez d'abord selectionner un client.");
            }



        }
    }
}