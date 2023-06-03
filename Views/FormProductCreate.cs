using AutoFact2.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AutoFact2.Views
{
    public partial class FormProductCreate : Form
    {
        public ProductController productController;

        public FormProductCreate()
        {
            InitializeComponent();
            productController = new ProductController();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string label = TxtLabel.Text;
            string unitPrice = TxtUnitPrice.Text;
            string type = ComboType.Text;

            productController.create(label, Convert.ToSingle(unitPrice), Convert.ToInt32(type));
        }
    }
}
