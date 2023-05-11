using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoFact2.Views
{
    public partial class FormProfil : Form
    {
        public FormProfil()
        {
            InitializeComponent();
        }

        private void FormProfil_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=../../AutoFact2BDD.db";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            connection.Open();

            string selectSql = "SELECT * FROM Profil";
            SQLiteCommand command = new SQLiteCommand(selectSql, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                txtRaisonSocial.Text = reader.GetString(1);
                txtSiren.Text = reader.GetInt32(2).ToString();
                txtAdresse.Text = reader.GetString(3);
                txtCP.Text = reader.GetInt32(4).ToString();
                txtVille.Text = reader.GetString(5);
                txtTel.Text = reader.GetString(6);
                txtEmail.Text = reader.GetString(7);
            }

            reader.Close();

            connection.Close();

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
