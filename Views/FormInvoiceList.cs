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
        public InvoiceController InController;

        public static int id;

        public FormInvoiceList()
        {
            InitializeComponent();
            InController = new InvoiceController();

           // MessageBox.Show("Ceci est un message d'information.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void FormInvoiceList_Load(object sender, EventArgs e)
        {
            LeRefresh();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.DgvInvoice.Columns[e.ColumnIndex].Name == "ColBtnUpdate")
            {
                int id = Convert.ToInt32(DgvInvoice.Rows[e.RowIndex].Cells["ColId"].Value);
                //FormInvoiceUpdate InvoiceUpdate = new FormInvoiceUpdate(id);
                //InvoiceUpdate.ShowDialog();
                //MessageBox.Show("sortis boite.");
                DgvInvoice.Refresh();
                //LeRefresh();


            } //e.RowIndex

            if (this.DgvInvoice.Columns[e.ColumnIndex].Name == "ColBtnPDF")
            {

                return;

            }

            if (this.DgvInvoice.Columns[e.ColumnIndex].Name == "ColBtnDetail")
            {
                int id = Convert.ToInt32(DgvInvoice.Rows[e.RowIndex].Cells["ColIdInvoice"].Value);
                FormInvoiceDetail InvoiceDetail = new FormInvoiceDetail(id);
                InvoiceDetail.ShowDialog();
            }
        }

        private void BtnCreateInvoice_Click(object sender, EventArgs e)
        {
            
            FormInvoiceDetail InvoiceDetail = new FormInvoiceDetail();
            InvoiceDetail.ShowDialog();

        }



        //Fonction de rafraichissement du datagriedview.
        public void LeRefresh()
        {
            //MessageBox.Show("test");
            this.DgvInvoice.Rows.Clear();
            foreach (var uneFacture in InController.findAll())
            {
                string dgvId = uneFacture.GetId().ToString();
                int dgvIdInvoice = uneFacture.GetidCustomer();
                DateTime dgvDateInvoice = uneFacture.GetDateInvoice();

                this.DgvInvoice.Rows.Add(dgvId, dgvIdInvoice, dgvDateInvoice, "Generer PDF", "Détails");
            }
        }
        
       /* public bool LeCreate()
        {
            FormInvoiceCreate InvoiceCreate = new FormInvoiceCreate();
            InvoiceCreate.ShowDialog();
            LeRefresh();
            DialogResult result = MessageBox.Show("Voulez vous crée un nouveaux Invoice ?", "Confirmation de l'enregistrement", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                return true;
            }
            return false;
        } */

        private void refresh_Click(object sender, EventArgs e)
        {
            LeRefresh();
        }
    }
}
