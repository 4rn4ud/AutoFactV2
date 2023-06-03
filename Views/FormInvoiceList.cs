using AutoFact2.Controllers;
using AutoFact2.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AutoFact2
{
    public partial class FormInvoiceList : Form
    {
        public InvoiceController invoiceController;
        public FormInvoiceList()
        {
            InitializeComponent();
            invoiceController = new InvoiceController();
        }


        public static int id;
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.DgvInvoice.Columns[e.ColumnIndex].Name == "ColBtnUpdate")
            {
                int id = Convert.ToInt32(DgvInvoice.Rows[e.RowIndex].Cells["ColId"].Value);
                FormInvoiceUpdate InvoiceUpdate = new FormInvoiceUpdate(id);
                InvoiceUpdate.ShowDialog();
                //MessageBox.Show("sortis boite.");
                DgvInvoice.Refresh();
                LeRefresh();


            } //e.RowIndex

            if (this.DgvInvoice.Columns[e.ColumnIndex].Name == "ColBtnPDF")
            {

                

            }
        }

        private void BtnCreateInvoice_Click(object sender, EventArgs e)
        {

        }
    }
}
