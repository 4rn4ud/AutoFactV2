using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoFact2
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnClientList_Click(object sender, EventArgs e)
        {
            FormClientList ClientList = new FormClientList();
            ClientList.Show();
        }

        private void btnClientUpdate_Click(object sender, EventArgs e)
        {
            FormClientUpdate ClientUpdate = new FormClientUpdate();
            ClientUpdate.Show();
        }

        private void btnClientCreate_Click(object sender, EventArgs e)
        {
            FormClientCreate ClientCreate = new FormClientCreate();
            ClientCreate.Show();
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            FormProductList ProductList = new FormProductList();
            ProductList.Show();
        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            FormProductUpdate ProductUpdate = new FormProductUpdate();
            ProductUpdate.Show();
        }

        private void btnProductCreate_Click(object sender, EventArgs e)
        {
            FormProductCreate ProductCreate = new FormProductCreate();
            ProductCreate.Show();
        }

        private void btnInvoiceList_Click(object sender, EventArgs e)
        {
            FormInvoiceList InvoiceList = new FormInvoiceList();
            InvoiceList.Show();
        }

        private void btnInvoiceUpdate_Click(object sender, EventArgs e)
        {
            FormInvoiceUpdate InvoiceUpdate = new FormInvoiceUpdate();
            InvoiceUpdate.Show();
        }

        private void btnInvoiceCreate_Click(object sender, EventArgs e)
        {
            FormInvoiceCreate InvoiceCreate = new FormInvoiceCreate();
            InvoiceCreate.Show();
        }
    }
}
