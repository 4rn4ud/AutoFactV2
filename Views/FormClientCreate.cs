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
    public partial class FormClientCreate : Form
    {
        public CustomerController customerController;
        public FormClientCreate()
        {
            InitializeComponent();
            customerController = new CustomerController();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text;
            string lastName = TxtSurname.Text;
            string companyName = TxtCompanyname.Text;
            string address = TxtAdresse.Text;
            int postalCode = Convert.ToInt32(TxtPostalCode.Text);
            string city = TxtCity.Text;
            string mail = TxtMail.Text;
            string tel = TxtTel.Text;

            customerController.create(name, lastName, companyName, address, postalCode, city, mail, tel);

            MessageBox.Show("Le client a bien été ajouté à la base de données.");

            ResetTextBoxes();
        }
        private void ResetTextBoxes()
        {
            TxtName.Text = string.Empty;
            TxtSurname.Text = string.Empty;
            TxtCompanyname.Text = string.Empty;
            TxtAdresse.Text = string.Empty;
            TxtPostalCode.Text = string.Empty;
            TxtCity.Text = string.Empty;
            TxtMail.Text = string.Empty;
            TxtTel.Text = string.Empty;
        }
    }
}
