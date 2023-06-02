using AutoFact2.Controllers;
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
    public partial class FormClientUpdate : Form
    {
        public CustomerController customerController;

        public FormClientUpdate()
        {
            InitializeComponent();
            customerController = new CustomerController();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormClientUpdate_Load(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            foreach (var unClient in customerController.findAll())
            {
                if (unClient.GetId() == RecupId(id)) 
                { 
                TxtName.Text = unClient.GetId().ToString();
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

            string name = TxtName.Text;
            string lastName = TxtSurname.Text;
            string companyName = TxtCompanyname.Text;
            string address = TxtAdresse.Text;
            int postalCode = Convert.ToInt32(TxtPostalCode.Text);
            string city = TxtCity.Text;
            string mail = TxtMail.Text;
            string tel = TxtTel.Text;



            customerController.create(name, lastName, companyName, address, postalCode, city, mail, tel);

            MessageBox.Show("Le client a bien été Modifier dans la base de données.");
        }

        public int RecupId(int id)
        {
            return id;
        }
    }
}
