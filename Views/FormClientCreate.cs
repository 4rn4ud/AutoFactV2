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
using System.Text.RegularExpressions;

namespace AutoFact2.Views
{
    public partial class FormClientCreate : Form
    {
        public CustomerController customerController;
        public FormClientCreate()
        {
            InitializeComponent();
            customerController = new CustomerController();
            TxtMail.TextChanged += TxtMail_TextChanged;
            TxtPostalCode.TextChanged += TxtPostalCode_TextChanged;
            TxtTel.TextChanged += TxtTel_TextChanged;
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

            //MessageBox.Show("Le client a bien été ajouté à la base de données.");

            ResetTextBoxes();
            this.Close();
            
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

        private void TxtMail_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string email = textBox.Text.Trim();

            // Expression régulière pour valider le format de l'adresse e-mail
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            bool isValidEmail = Regex.IsMatch(email, emailPattern);

            if (isValidEmail)
            {
                // L'adresse e-mail est valide
                textBox.ForeColor = Color.Black;
            }
            else
            {
                // L'adresse e-mail est invalide
                textBox.ForeColor = Color.Red;
            }
        }

        private void TxtPostalCode_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string postalCode = textBox.Text.Trim();

            // Expression régulière pour valider le format du code postal (exemple pour la France)
            string postalCodePattern = @"^\d{5}$";
            bool isValidPostalCode = Regex.IsMatch(postalCode, postalCodePattern);

            if (isValidPostalCode)
            {
                // Le code postal est valide
                textBox.ForeColor = Color.Black;
            }
            else
            {
                // Le code postal est invalide
                textBox.ForeColor = Color.Red;
            }
        }
        private void TxtTel_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string tel = textBox.Text.Trim();

            // Expression régulière pour valider le format du numéro de téléphone (exemple pour les numéros français)
            string telPattern = @"^(0|\+33)\d{9}$";
            bool isValidTel = Regex.IsMatch(tel, telPattern);

            if (isValidTel)
            {
                // Le numéro de téléphone est valide
                textBox.ForeColor = Color.Black;
            }
            else
            {
                // Le numéro de téléphone est invalide
                textBox.ForeColor = Color.Red;
            }
        }

    }
}
