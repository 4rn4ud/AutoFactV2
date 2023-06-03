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
        public FormInvoiceList()
        {
            InitializeComponent();
            InController = new InvoiceController();
        }


        public static int id;
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.DgvIncoice.Columns[e.ColumnIndex].Name == "ColBtnUpdate")
            {
                int id = Convert.ToInt32(DgvIncoice.Rows[e.RowIndex].Cells["ColId"].Value);
                //FormInvoiceUpdate InvoiceUpdate = new FormInvoiceUpdate(id);
                //InvoiceUpdate.ShowDialog();
                //MessageBox.Show("sortis boite.");
                DgvIncoice.Refresh();
                //LeRefresh();


            } //e.RowIndex

            if (this.DgvIncoice.Columns[e.ColumnIndex].Name == "ColBtnPDF")
            {

                return;

            }
        }

        private void BtnCreateInvoice_Click(object sender, EventArgs e)
        {
            FormInvoiceCreate InvoiceCreate = new FormInvoiceCreate();
            InvoiceCreate.ShowDialog();

        }

        private void FormClientList_Load(object sender, EventArgs e)
        {
            LeRefresh();
        }

        //Fonction de rafraichissement du datagriedview.
        public void LeRefresh()
        {
            this.DgvIncoice.Rows.Clear();
            foreach (var uneFacture in InController.findAll())
            {
                string dgvId = uneFacture.GetId().ToString();
                int dgvIdInvoice = uneFacture.GetidCustomer();
                DateTime dgvDateInvoice = uneFacture.GetDateInvoice();

                this.DgvIncoice.Rows.Add(dgvId, dgvIdInvoice, dgvDateInvoice, "Generer PDF", "Supprimer");
            }
        }
        
        public bool LeCreate()
        {
            FormClientCreate ClientCreate = new FormClientCreate();
            ClientCreate.ShowDialog();
            LeRefresh();
            DialogResult result = MessageBox.Show("Voulez vous crée un nouveaux client ?", "Confirmation de l'enregistrement", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
    }
}
