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
            this.ComboType = new System.Windows.Forms.ComboBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.LabelIdType = new System.Windows.Forms.Label();
            this.LabelPrix = new System.Windows.Forms.Label();
            this.LabelLibelle = new System.Windows.Forms.Label();
            this.TxtUnitPrice = new System.Windows.Forms.TextBox();
            this.TxtLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ComboType
            // 
            this.ComboType.FormattingEnabled = true;
            this.ComboType.Location = new System.Drawing.Point(449, 252);
            this.ComboType.Name = "ComboType";
            this.ComboType.Size = new System.Drawing.Size(121, 21);
            this.ComboType.TabIndex = 16;
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
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(449, 500);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(75, 23);
            this.BtnCreate.TabIndex = 14;
            this.BtnCreate.Text = "Enregistrer";
            this.BtnCreate.UseVisualStyleBackColor = true;
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
            this.LabelLibelle.Text = "Libelle";
            // 
            // TxtUnitPrice
            // 
            this.TxtUnitPrice.Location = new System.Drawing.Point(449, 197);
            this.TxtUnitPrice.Name = "TxtUnitPrice";
            this.TxtUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.TxtUnitPrice.TabIndex = 10;
            // 
            // TxtLabel
            // 
            this.TxtLabel.Location = new System.Drawing.Point(449, 152);
            this.TxtLabel.Name = "TxtLabel";
            this.TxtLabel.Size = new System.Drawing.Size(100, 20);
            this.TxtLabel.TabIndex = 9;
            // 
            // FormProductUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.ComboType);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnCreate);
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

        private System.Windows.Forms.ComboBox ComboType;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Label LabelIdType;
        private System.Windows.Forms.Label LabelPrix;
        private System.Windows.Forms.Label LabelLibelle;
        private System.Windows.Forms.TextBox TxtUnitPrice;
        private System.Windows.Forms.TextBox TxtLabel;
    }
}