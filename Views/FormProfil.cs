﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoFact2.Controllers;
using AutoFact2.Views;

namespace AutoFact2.Views
{
    public partial class FormProfil : Form
    {
        public ProfilController profilController;
        public FormProfil()
        {
            InitializeComponent();
            profilController = new ProfilController();  
        }

        private void FormProfil_Load(object sender, EventArgs e)
         {
            foreach(Profil unProfil in profilController.findAll())
            {
                txtRaisonSocial.Text = unProfil.GetSocialReason();
                txtSiren.Text = unProfil.GetSiren().ToString();
                txtAdresse.Text = unProfil.GetAdress();
                txtCP.Text = unProfil.GetPostalCode().ToString();
                txtVille.Text = unProfil.GetCity();
                txtTel.Text = unProfil.GetTel();
                txtEmail.Text = unProfil.GetMail();
                MessageBox.Show("tst");
            }

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
