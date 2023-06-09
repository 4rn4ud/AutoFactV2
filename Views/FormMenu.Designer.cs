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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.btnStats = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClientList
            // 
            this.btnClientList.Location = new System.Drawing.Point(94, 87);
            this.btnClientList.Name = "btnClientList";
            this.btnClientList.Size = new System.Drawing.Size(156, 30);
            this.btnClientList.TabIndex = 0;
            this.btnClientList.Text = "Gestion des clients";
            this.btnClientList.UseVisualStyleBackColor = true;
            this.btnClientList.Click += new System.EventHandler(this.btnClientList_Click);
            // 
            // btnProductList
            // 
            this.btnProductList.Location = new System.Drawing.Point(94, 140);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(156, 30);
            this.btnProductList.TabIndex = 3;
            this.btnProductList.Text = "Gestion des produits";
            this.btnProductList.UseVisualStyleBackColor = true;
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // btnInvoiceList
            // 
            this.btnInvoiceList.Location = new System.Drawing.Point(94, 193);
            this.btnInvoiceList.Name = "btnInvoiceList";
            this.btnInvoiceList.Size = new System.Drawing.Size(156, 30);
            this.btnInvoiceList.TabIndex = 6;
            this.btnInvoiceList.Text = "Gestion des factures";
            this.btnInvoiceList.UseVisualStyleBackColor = true;
            this.btnInvoiceList.Click += new System.EventHandler(this.btnInvoiceList_Click);
            // 
            // btnProfil
            // 
            this.btnProfil.Location = new System.Drawing.Point(679, 87);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(156, 30);
            this.btnProfil.TabIndex = 9;
            this.btnProfil.Text = "A propos de";
            this.btnProfil.UseVisualStyleBackColor = true;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(300, 87);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 325);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // LabelTitle
            // 
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(339, 15);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelTitle.Size = new System.Drawing.Size(225, 41);
            this.LabelTitle.TabIndex = 14;
            this.LabelTitle.Text = "AutoFact2";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(679, 193);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(156, 23);
            this.btnStats.TabIndex = 15;
            this.btnStats.Text = "Statistiques";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 449);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnProfil);
            this.Controls.Add(this.btnInvoiceList);
            this.Controls.Add(this.btnProductList);
            this.Controls.Add(this.btnClientList);
            this.Name = "FormMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoFact";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientList;
        private System.Windows.Forms.Button btnProductList;
        private System.Windows.Forms.Button btnInvoiceList;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button btnStats;
    }
}

