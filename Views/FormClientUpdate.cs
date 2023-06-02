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

        public FormClientUpdate(int id)
        {
            InitializeComponent();
            customerController = new CustomerController();

            foreach (var unClient in customerController.findAll())
            { 
                //MessageBox.Show(Convert.ToString(unClient.GetId()));

                if (unClient.GetId() == id)
                {
                    TxtId.Text = unClient.GetId().ToString(); 
                    TxtName.Text = unClient.GetName();
                    TxtName.Text = unClient.GetName();
                    TxtSurname.Text = unClient.GetLastname();
                    TxtCompanyname.Text = unClient.GetCompanyName();
                    TxtAdresse.Text = unClient.GetAdress();
                    TxtPostalCode.Text = unClient.GetPostalCode().ToString();
                    TxtCity.Text = unClient.GetCity();
                    TxtMail.Text = unClient.GetMail();
                    TxtTel.Text = unClient.GetTel();

                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormClientUpdate_Load(object sender, EventArgs e)
        {

        }


        private void BtnUpdate_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtId.Text);
            string name = TxtName.Text;
            string lastName = TxtSurname.Text;
            string companyName = TxtCompanyname.Text;
            string address = TxtAdresse.Text;
            int postalCode = Convert.ToInt32(TxtPostalCode.Text);
            string city = TxtCity.Text;
            string mail = TxtMail.Text;
            string tel = TxtTel.Text;
            

            customerController.update(id, name, lastName, companyName, address, postalCode, city, mail, tel);
            //int id, string name, string lastName, string companyName, string address, int postalCode, string city, string mail, string tel
            MessageBox.Show("Le client a bien été Modifier dans la base de données.");
            this.Close();
        }
    }
}
