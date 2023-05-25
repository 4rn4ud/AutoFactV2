using AutoFact2.Controllers;
using AutoFact2.Views;
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
    public partial class FormClientList : Form
    {
        public CustomerController customerController;
        public FormClientList()
        {
            InitializeComponent();
            customerController = new CustomerController();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){}

        private void BtnCreateClient_Click(object sender, EventArgs e)
        {
            FormClientCreate ClientCreate = new FormClientCreate();
            ClientCreate.Show();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormClientList_Load(object sender, EventArgs e)
        {
            foreach (var unClient in customerController.findAll())
            {
                string dgvId = unClient.GetId().ToString();
                string dgvName = unClient.GetName();
                string dgvLastName = unClient.GetLastname();
                string dgvCompanyName = unClient.GetCompanyName();
                string dgvAdress = unClient.GetAdress();
                string dgvPostalCode = unClient.GetPostalCode().ToString();
                string dgvCity = unClient.GetCity();
                string dgvMail = unClient.GetMail();
                string dgvTel = unClient.GetTel();
                this.DgvClient.Rows.Add(dgvId, dgvName, dgvLastName, dgvCompanyName, dgvAdress, dgvPostalCode, dgvCity, dgvMail, dgvTel, "Modifier", "Supprimer");
            }
        }
    }
}
