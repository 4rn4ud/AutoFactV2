namespace AutoFact2.Views
{
    partial class FormInvoiceDetail
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
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.DgvInvoiceline = new System.Windows.Forms.DataGridView();
            this.ColIdQuote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPromotion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtIdCustomer = new System.Windows.Forms.TextBox();
            this.LabelId = new System.Windows.Forms.Label();
            this.LabelIdClient = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInvoiceline)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(333, 447);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "Retour";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(521, 446);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 1;
            this.BtnUpdate.Text = "Modifier";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // DgvInvoiceline
            // 
            this.DgvInvoiceline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInvoiceline.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdQuote,
            this.ColIdProduct,
            this.ColQuantity,
            this.ColPromotion,
            this.ColPrix});
            this.DgvInvoiceline.Location = new System.Drawing.Point(141, 193);
            this.DgvInvoiceline.Name = "DgvInvoiceline";
            this.DgvInvoiceline.RowHeadersWidth = 51;
            this.DgvInvoiceline.RowTemplate.Height = 24;
            this.DgvInvoiceline.Size = new System.Drawing.Size(684, 150);
            this.DgvInvoiceline.TabIndex = 2;
            this.DgvInvoiceline.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInvoiceline_CellContentClick);
            // 
            // ColIdQuote
            // 
            this.ColIdQuote.HeaderText = "idQuote";
            this.ColIdQuote.MinimumWidth = 6;
            this.ColIdQuote.Name = "ColIdQuote";
            this.ColIdQuote.Width = 125;
            // 
            // ColIdProduct
            // 
            this.ColIdProduct.HeaderText = "IdProduct";
            this.ColIdProduct.MinimumWidth = 6;
            this.ColIdProduct.Name = "ColIdProduct";
            this.ColIdProduct.Width = 125;
            // 
            // ColQuantity
            // 
            this.ColQuantity.HeaderText = "Quantity";
            this.ColQuantity.MinimumWidth = 6;
            this.ColQuantity.Name = "ColQuantity";
            this.ColQuantity.Width = 125;
            // 
            // ColPromotion
            // 
            this.ColPromotion.HeaderText = "ColPromotion";
            this.ColPromotion.MinimumWidth = 6;
            this.ColPromotion.Name = "ColPromotion";
            this.ColPromotion.Width = 125;
            // 
            // ColPrix
            // 
            this.ColPrix.HeaderText = "Prix";
            this.ColPrix.MinimumWidth = 6;
            this.ColPrix.Name = "ColPrix";
            this.ColPrix.Width = 125;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(141, 50);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 22);
            this.TxtId.TabIndex = 3;
            // 
            // TxtIdCustomer
            // 
            this.TxtIdCustomer.Location = new System.Drawing.Point(141, 109);
            this.TxtIdCustomer.Name = "TxtIdCustomer";
            this.TxtIdCustomer.Size = new System.Drawing.Size(100, 22);
            this.TxtIdCustomer.TabIndex = 4;
            // 
            // LabelId
            // 
            this.LabelId.AutoSize = true;
            this.LabelId.Location = new System.Drawing.Point(105, 53);
            this.LabelId.Name = "LabelId";
            this.LabelId.Size = new System.Drawing.Size(18, 16);
            this.LabelId.TabIndex = 5;
            this.LabelId.Text = "Id";
            // 
            // LabelIdClient
            // 
            this.LabelIdClient.AutoSize = true;
            this.LabelIdClient.Location = new System.Drawing.Point(63, 111);
            this.LabelIdClient.Name = "LabelIdClient";
            this.LabelIdClient.Size = new System.Drawing.Size(51, 16);
            this.LabelIdClient.TabIndex = 7;
            this.LabelIdClient.Text = "IdClient";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(518, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date";
            // 
            // TxtDate
            // 
            this.TxtDate.Location = new System.Drawing.Point(584, 53);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(100, 22);
            this.TxtDate.TabIndex = 9;
            // 
            // FormInvoiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 544);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelIdClient);
            this.Controls.Add(this.LabelId);
            this.Controls.Add(this.TxtIdCustomer);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.DgvInvoiceline);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnBack);
            this.Name = "FormInvoiceDetail";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DgvInvoiceline)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.DataGridView DgvInvoiceline;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdQuote;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPromotion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrix;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtIdCustomer;
        private System.Windows.Forms.Label LabelId;
        private System.Windows.Forms.Label LabelIdClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDate;
    }
}