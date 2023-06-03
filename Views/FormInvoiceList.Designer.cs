﻿namespace AutoFact2
{
    partial class FormInvoiceList
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
            this.DgvInvoice = new System.Windows.Forms.DataGridView();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnCreateInvoice = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.ColIdInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIdCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIdProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPromo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colidtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coldate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBtnPDF = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColBtnDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvInvoice
            // 
            this.DgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdInvoice,
            this.ColIdCustomer,
            this.CIdProduit,
            this.ColQuantity,
            this.ColPromo,
            this.Colidtype,
            this.Coldate,
            this.ColBtnPDF,
            this.ColBtnDetail});
            this.DgvInvoice.Location = new System.Drawing.Point(-13, 128);
            this.DgvInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.DgvInvoice.Name = "DgvInvoice";
            this.DgvInvoice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DgvInvoice.RowHeadersWidth = 51;
            this.DgvInvoice.Size = new System.Drawing.Size(1312, 185);
            this.DgvInvoice.TabIndex = 0;
            this.DgvInvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(647, 510);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(104, 28);
            this.BtnBack.TabIndex = 3;
            this.BtnBack.Text = "Retour";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnCreateInvoice
            // 
            this.BtnCreateInvoice.Location = new System.Drawing.Point(465, 510);
            this.BtnCreateInvoice.Name = "BtnCreateInvoice";
            this.BtnCreateInvoice.Size = new System.Drawing.Size(114, 28);
            this.BtnCreateInvoice.TabIndex = 4;
            this.BtnCreateInvoice.Text = "Créer";
            this.BtnCreateInvoice.UseVisualStyleBackColor = true;
            this.BtnCreateInvoice.Click += new System.EventHandler(this.BtnCreateInvoice_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(234, 510);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(94, 23);
            this.refresh.TabIndex = 5;
            this.refresh.Text = "BtnRefresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // ColIdInvoice
            // 
            this.ColIdInvoice.HeaderText = "Id";
            this.ColIdInvoice.MinimumWidth = 6;
            this.ColIdInvoice.Name = "ColIdInvoice";
            this.ColIdInvoice.ReadOnly = true;
            this.ColIdInvoice.Width = 125;
            // 
            // ColIdCustomer
            // 
            this.ColIdCustomer.HeaderText = "IdCustomer";
            this.ColIdCustomer.MinimumWidth = 6;
            this.ColIdCustomer.Name = "ColIdCustomer";
            this.ColIdCustomer.ReadOnly = true;
            this.ColIdCustomer.Width = 125;
            // 
            // CIdProduit
            // 
            this.CIdProduit.HeaderText = "IdProduit";
            this.CIdProduit.MinimumWidth = 6;
            this.CIdProduit.Name = "CIdProduit";
            this.CIdProduit.Width = 125;
            // 
            // ColQuantity
            // 
            this.ColQuantity.HeaderText = "Quantiter";
            this.ColQuantity.MinimumWidth = 6;
            this.ColQuantity.Name = "ColQuantity";
            this.ColQuantity.Width = 125;
            // 
            // ColPromo
            // 
            this.ColPromo.HeaderText = "Promotion";
            this.ColPromo.MinimumWidth = 6;
            this.ColPromo.Name = "ColPromo";
            this.ColPromo.Width = 125;
            // 
            // Colidtype
            // 
            this.Colidtype.HeaderText = "IdType";
            this.Colidtype.MinimumWidth = 6;
            this.Colidtype.Name = "Colidtype";
            this.Colidtype.Width = 125;
            // 
            // Coldate
            // 
            this.Coldate.HeaderText = "Date";
            this.Coldate.MinimumWidth = 6;
            this.Coldate.Name = "Coldate";
            this.Coldate.Width = 125;
            // 
            // ColBtnPDF
            // 
            this.ColBtnPDF.HeaderText = "Génerer PDF";
            this.ColBtnPDF.MinimumWidth = 6;
            this.ColBtnPDF.Name = "ColBtnPDF";
            this.ColBtnPDF.Width = 125;
            // 
            // ColBtnDetail
            // 
            this.ColBtnDetail.HeaderText = "Detail";
            this.ColBtnDetail.MinimumWidth = 6;
            this.ColBtnDetail.Name = "ColBtnDetail";
            this.ColBtnDetail.Width = 125;
            // 
            // FormInvoiceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.BtnCreateInvoice);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.DgvInvoice);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormInvoiceList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceList";
            ((System.ComponentModel.ISupportInitialize)(this.DgvInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvInvoice;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnCreateInvoice;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPromo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colidtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coldate;
        private System.Windows.Forms.DataGridViewButtonColumn ColBtnPDF;
        private System.Windows.Forms.DataGridViewButtonColumn ColBtnDetail;
    }
}