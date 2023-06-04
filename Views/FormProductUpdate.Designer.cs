namespace AutoFact2.Views
{
    partial class FormProductUpdate
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
            this.ComboCategory = new System.Windows.Forms.ComboBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.LabelIdType = new System.Windows.Forms.Label();
            this.LabelPrix = new System.Windows.Forms.Label();
            this.LabelLibelle = new System.Windows.Forms.Label();
            this.TxtUnitPrice = new System.Windows.Forms.TextBox();
            this.TxtLabel = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.LabelId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboCategory
            // 
            this.ComboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCategory.FormattingEnabled = true;
            this.ComboCategory.Items.AddRange(new object[] {
            "1. Service",
            "2. Produit"});
            this.ComboCategory.Location = new System.Drawing.Point(449, 252);
            this.ComboCategory.Name = "ComboCategory";
            this.ComboCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ComboCategory.Size = new System.Drawing.Size(121, 21);
            this.ComboCategory.TabIndex = 16;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(63, 35);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 15;
            this.BtnBack.Text = "Retour";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(449, 500);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 14;
            this.BtnUpdate.Text = "Enregistrer";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // LabelIdType
            // 
            this.LabelIdType.AutoSize = true;
            this.LabelIdType.Location = new System.Drawing.Point(360, 255);
            this.LabelIdType.Name = "LabelIdType";
            this.LabelIdType.Size = new System.Drawing.Size(31, 13);
            this.LabelIdType.TabIndex = 13;
            this.LabelIdType.Text = "Type";
            // 
            // LabelPrix
            // 
            this.LabelPrix.AutoSize = true;
            this.LabelPrix.Location = new System.Drawing.Point(360, 203);
            this.LabelPrix.Name = "LabelPrix";
            this.LabelPrix.Size = new System.Drawing.Size(61, 13);
            this.LabelPrix.TabIndex = 12;
            this.LabelPrix.Text = "Prix unitaire";
            // 
            // LabelLibelle
            // 
            this.LabelLibelle.AutoSize = true;
            this.LabelLibelle.Location = new System.Drawing.Point(360, 158);
            this.LabelLibelle.Name = "LabelLibelle";
            this.LabelLibelle.Size = new System.Drawing.Size(37, 13);
            this.LabelLibelle.TabIndex = 11;
            this.LabelLibelle.Text = "Libellé";
            // 
            // TxtUnitPrice
            // 
            this.TxtUnitPrice.Location = new System.Drawing.Point(449, 197);
            this.TxtUnitPrice.Name = "TxtUnitPrice";
            this.TxtUnitPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.TxtUnitPrice.TabIndex = 10;
            // 
            // TxtLabel
            // 
            this.TxtLabel.Location = new System.Drawing.Point(449, 152);
            this.TxtLabel.Name = "TxtLabel";
            this.TxtLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtLabel.Size = new System.Drawing.Size(100, 20);
            this.TxtLabel.TabIndex = 9;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(449, 109);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtId.Size = new System.Drawing.Size(100, 20);
            this.TxtId.TabIndex = 17;
            // 
            // LabelId
            // 
            this.LabelId.AutoSize = true;
            this.LabelId.Location = new System.Drawing.Point(360, 112);
            this.LabelId.Name = "LabelId";
            this.LabelId.Size = new System.Drawing.Size(16, 13);
            this.LabelId.TabIndex = 18;
            this.LabelId.Text = "Id";
            // 
            // FormProductUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.LabelId);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.ComboCategory);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.LabelIdType);
            this.Controls.Add(this.LabelPrix);
            this.Controls.Add(this.LabelLibelle);
            this.Controls.Add(this.TxtUnitPrice);
            this.Controls.Add(this.TxtLabel);
            this.Name = "FormProductUpdate";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoFact";
            this.Load += new System.EventHandler(this.FormProductUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboCategory;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Label LabelIdType;
        private System.Windows.Forms.Label LabelPrix;
        private System.Windows.Forms.Label LabelLibelle;
        private System.Windows.Forms.TextBox TxtUnitPrice;
        private System.Windows.Forms.TextBox TxtLabel;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label LabelId;
    }
}