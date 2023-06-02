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
    public partial class FormProductList : Form
    {
        public ProductController productController;
        public FormProductList()
        {
            InitializeComponent();
            productController = new ProductController();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            FormProductCreate ProductCreate = new FormProductCreate();
            ProductCreate.Show();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProductList_Load(object sender, EventArgs e)
        {
            foreach (var unProduit in productController.findAll())
            {
                string dgvId = unProduit.GetId().ToString();
                string dgvLibel = unProduit.GetLibel();
                string dgvUnitPrice = unProduit.GetUnitPrice().ToString();
                string dgvIdCategory = unProduit.GetIdCategory().ToString();
                this.DgvProduit.Rows.Add(dgvId, dgvLibel, dgvUnitPrice, dgvIdCategory, "Modifier", "Supprimer");
            }
        }
    }
}
