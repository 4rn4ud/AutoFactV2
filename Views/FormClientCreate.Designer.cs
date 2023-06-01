namespace AutoFact2.Views
{
    partial class FormClientCreate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.TxtCompanyname = new System.Windows.Forms.TextBox();
            this.TxtAdresse = new System.Windows.Forms.TextBox();
            this.TxtPostalCode = new System.Windows.Forms.TextBox();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtTel = new System.Windows.Forms.TextBox();
            this.LabelMail = new System.Windows.Forms.Label();
            this.LabelTel = new System.Windows.Forms.Label();
            this.LabelCity = new System.Windows.Forms.Label();
            this.LabelPostalcode = new System.Windows.Forms.Label();
            this.LabelAdresse = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelSurname = new System.Windows.Forms.Label();
            this.LabelCompagny = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(52, 22);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "Retour";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(419, 460);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(75, 23);
            this.BtnCreate.TabIndex = 1;
            this.BtnCreate.Text = "Enregistrer";
            this.BtnCreate.UseVisualStyleBackColor = true;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(149, 144);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 2;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(149, 206);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(100, 20);
            this.TxtSurname.TabIndex = 3;
            // 
            // TxtCompanyname
            // 
            this.TxtCompanyname.Location = new System.Drawing.Point(149, 267);
            this.TxtCompanyname.Name = "TxtCompanyname";
            this.TxtCompanyname.Size = new System.Drawing.Size(100, 20);
            this.TxtCompanyname.TabIndex = 4;
            // 
            // TxtAdresse
            // 
            this.TxtAdresse.Location = new System.Drawing.Point(409, 144);
            this.TxtAdresse.Name = "TxtAdresse";
            this.TxtAdresse.Size = new System.Drawing.Size(100, 20);
            this.TxtAdresse.TabIndex = 5;
            // 
            // TxtPostalCode
            // 
            this.TxtPostalCode.Location = new System.Drawing.Point(409, 206);
            this.TxtPostalCode.Name = "TxtPostalCode";
            this.TxtPostalCode.Size = new System.Drawing.Size(100, 20);
            this.TxtPostalCode.TabIndex = 6;
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(409, 268);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(100, 20);
            this.TxtCity.TabIndex = 7;
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(667, 144);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(100, 20);
            this.TxtMail.TabIndex = 8;
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(667, 206);
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(100, 20);
            this.TxtTel.TabIndex = 9;
            // 
            // LabelMail
            // 
            this.LabelMail.AutoSize = true;
            this.LabelMail.Location = new System.Drawing.Point(579, 144);
            this.LabelMail.Name = "LabelMail";
            this.LabelMail.Size = new System.Drawing.Size(26, 13);
            this.LabelMail.TabIndex = 11;
            this.LabelMail.Text = "Mail";
            // 
            // LabelTel
            // 
            this.LabelTel.AutoSize = true;
            this.LabelTel.Location = new System.Drawing.Point(579, 206);
            this.LabelTel.Name = "LabelTel";
            this.LabelTel.Size = new System.Drawing.Size(22, 13);
            this.LabelTel.TabIndex = 12;
            this.LabelTel.Text = "Tel";
            // 
            // LabelCity
            // 
            this.LabelCity.AutoSize = true;
            this.LabelCity.Location = new System.Drawing.Point(314, 268);
            this.LabelCity.Name = "LabelCity";
            this.LabelCity.Size = new System.Drawing.Size(26, 13);
            this.LabelCity.TabIndex = 14;
            this.LabelCity.Text = "Ville";
            // 
            // LabelPostalcode
            // 
            this.LabelPostalcode.AutoSize = true;
            this.LabelPostalcode.Location = new System.Drawing.Point(314, 212);
            this.LabelPostalcode.Name = "LabelPostalcode";
            this.LabelPostalcode.Size = new System.Drawing.Size(63, 13);
            this.LabelPostalcode.TabIndex = 15;
            this.LabelPostalcode.Text = "Code postal";
            // 
            // LabelAdresse
            // 
            this.LabelAdresse.AutoSize = true;
            this.LabelAdresse.Location = new System.Drawing.Point(314, 150);
            this.LabelAdresse.Name = "LabelAdresse";
            this.LabelAdresse.Size = new System.Drawing.Size(45, 13);
            this.LabelAdresse.TabIndex = 16;
            this.LabelAdresse.Text = "Adresse";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(52, 143);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(43, 13);
            this.LabelName.TabIndex = 17;
            this.LabelName.Text = "Prenom";
            // 
            // LabelSurname
            // 
            this.LabelSurname.AutoSize = true;
            this.LabelSurname.Location = new System.Drawing.Point(52, 205);
            this.LabelSurname.Name = "LabelSurname";
            this.LabelSurname.Size = new System.Drawing.Size(29, 13);
            this.LabelSurname.TabIndex = 18;
            this.LabelSurname.Text = "Nom";
            // 
            // LabelCompagny
            // 
            this.LabelCompagny.AutoSize = true;
            this.LabelCompagny.Location = new System.Drawing.Point(52, 267);
            this.LabelCompagny.Name = "LabelCompagny";
            this.LabelCompagny.Size = new System.Drawing.Size(84, 13);
            this.LabelCompagny.TabIndex = 19;
            this.LabelCompagny.Text = "Nom compagnie";
            // 
            // FormClientCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.LabelCompagny);
            this.Controls.Add(this.LabelSurname);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelAdresse);
            this.Controls.Add(this.LabelPostalcode);
            this.Controls.Add(this.LabelCity);
            this.Controls.Add(this.LabelTel);
            this.Controls.Add(this.LabelMail);
            this.Controls.Add(this.TxtTel);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.TxtPostalCode);
            this.Controls.Add(this.TxtAdresse);
            this.Controls.Add(this.TxtCompanyname);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.BtnBack);
            this.Name = "FormClientCreate";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoFact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.TextBox TxtCompanyname;
        private System.Windows.Forms.TextBox TxtAdresse;
        private System.Windows.Forms.TextBox TxtPostalCode;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtTel;
        private System.Windows.Forms.Label LabelMail;
        private System.Windows.Forms.Label LabelTel;
        private System.Windows.Forms.Label LabelCity;
        private System.Windows.Forms.Label LabelPostalcode;
        private System.Windows.Forms.Label LabelAdresse;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelSurname;
        private System.Windows.Forms.Label LabelCompagny;
    }
}