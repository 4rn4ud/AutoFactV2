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
        public FormClientList()
        {
            InitializeComponent();
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
    }
}
