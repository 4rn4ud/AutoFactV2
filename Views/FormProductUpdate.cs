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
using System.Xml.Linq;

namespace AutoFact2.Views
{
    public partial class FormProductUpdate : Form
    {
        public ProductController productController;

        public FormProductUpdate(int id)
        {
            InitializeComponent();
            productController = new ProductController();

            foreach (var unProduit in productController.findAll())
            {
                if (unProduit.GetId() == id)
                {
                    TxtId.Text = unProduit.GetId().ToString();
                    TxtName.Text = unProduit.GetName();
                    TxtName.Text = unProduit.GetName();
                    TxtSurname.Text = unProduit.GetLastname();
                    TxtCompanyname.Text = unProduit.GetCompanyName();
                    TxtAdresse.Text = unProduit.GetAdress();
                    TxtPostalCode.Text = unProduit.GetPostalCode().ToString();
                    TxtCity.Text = unProduit.GetCity();
                    TxtMail.Text = unProduit.GetMail();
                    TxtTel.Text = unProduit.GetTel();

                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProductUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
