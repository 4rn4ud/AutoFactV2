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
                    TxtLabel.Text = unProduit.GetId().ToString();
                    TxtUnitPrice.Text = unProduit.GetUnitPrice().ToString();
                    ComboType.Text = unProduit.GetType().ToString();
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
