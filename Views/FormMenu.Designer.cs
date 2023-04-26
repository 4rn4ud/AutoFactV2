namespace AutoFact2
{
    partial class FormMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClientList = new System.Windows.Forms.Button();
            this.btnProductList = new System.Windows.Forms.Button();
            this.btnInvoiceList = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClientList
            // 
            this.btnClientList.Location = new System.Drawing.Point(125, 107);
            this.btnClientList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClientList.Name = "btnClientList";
            this.btnClientList.Size = new System.Drawing.Size(147, 37);
            this.btnClientList.TabIndex = 0;
            this.btnClientList.Text = "Liste des clients";
            this.btnClientList.UseVisualStyleBackColor = true;
            this.btnClientList.Click += new System.EventHandler(this.btnClientList_Click);
            // 
            // btnProductList
            // 
            this.btnProductList.Location = new System.Drawing.Point(125, 296);
            this.btnProductList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(147, 37);
            this.btnProductList.TabIndex = 3;
            this.btnProductList.Text = "Liste des produits";
            this.btnProductList.UseVisualStyleBackColor = true;
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // btnInvoiceList
            // 
            this.btnInvoiceList.Location = new System.Drawing.Point(1065, 122);
            this.btnInvoiceList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInvoiceList.Name = "btnInvoiceList";
            this.btnInvoiceList.Size = new System.Drawing.Size(147, 37);
            this.btnInvoiceList.TabIndex = 6;
            this.btnInvoiceList.Text = "Liste des factures";
            this.btnInvoiceList.UseVisualStyleBackColor = true;
            this.btnInvoiceList.Click += new System.EventHandler(this.btnInvoiceList_Click);
            // 
            // btnProfil
            // 
            this.btnProfil.Location = new System.Drawing.Point(1065, 296);
            this.btnProfil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(147, 37);
            this.btnProfil.TabIndex = 9;
            this.btnProfil.Text = "Profil";
            this.btnProfil.UseVisualStyleBackColor = true;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(1065, 501);
            this.button12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(147, 37);
            this.button12.TabIndex = 11;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(587, 578);
            this.button13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(147, 37);
            this.button13.TabIndex = 12;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.btnProfil);
            this.Controls.Add(this.btnInvoiceList);
            this.Controls.Add(this.btnProductList);
            this.Controls.Add(this.btnClientList);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoFact";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientList;
        private System.Windows.Forms.Button btnProductList;
        private System.Windows.Forms.Button btnInvoiceList;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
    }
}

