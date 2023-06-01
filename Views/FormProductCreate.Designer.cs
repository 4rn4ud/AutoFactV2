namespace AutoFact2.Views
{
    partial class FormProductCreate
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
            this.TxtLibelle = new System.Windows.Forms.TextBox();
            this.TxtPrix = new System.Windows.Forms.TextBox();
            this.LabelLibelle = new System.Windows.Forms.Label();
            this.LabelPrix = new System.Windows.Forms.Label();
            this.LabelIdType = new System.Windows.Forms.Label();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.ComboType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TxtLibelle
            // 
            this.TxtLibelle.Location = new System.Drawing.Point(411, 150);
            this.TxtLibelle.Name = "TxtLibelle";
            this.TxtLibelle.Size = new System.Drawing.Size(100, 20);
            this.TxtLibelle.TabIndex = 0;
            // 
            // TxtPrix
            // 
            this.TxtPrix.Location = new System.Drawing.Point(411, 195);
            this.TxtPrix.Name = "TxtPrix";
            this.TxtPrix.Size = new System.Drawing.Size(100, 20);
            this.TxtPrix.TabIndex = 1;
            // 
            // LabelLibelle
            // 
            this.LabelLibelle.AutoSize = true;
            this.LabelLibelle.Location = new System.Drawing.Point(322, 156);
            this.LabelLibelle.Name = "LabelLibelle";
            this.LabelLibelle.Size = new System.Drawing.Size(37, 13);
            this.LabelLibelle.TabIndex = 3;
            this.LabelLibelle.Text = "Libelle";
            // 
            // LabelPrix
            // 
            this.LabelPrix.AutoSize = true;
            this.LabelPrix.Location = new System.Drawing.Point(322, 201);
            this.LabelPrix.Name = "LabelPrix";
            this.LabelPrix.Size = new System.Drawing.Size(61, 13);
            this.LabelPrix.TabIndex = 4;
            this.LabelPrix.Text = "Prix unitaire";
            // 
            // LabelIdType
            // 
            this.LabelIdType.AutoSize = true;
            this.LabelIdType.Location = new System.Drawing.Point(322, 253);
            this.LabelIdType.Name = "LabelIdType";
            this.LabelIdType.Size = new System.Drawing.Size(31, 13);
            this.LabelIdType.TabIndex = 5;
            this.LabelIdType.Text = "Type";
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(411, 498);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(75, 23);
            this.BtnCreate.TabIndex = 6;
            this.BtnCreate.Text = "Enregistrer";
            this.BtnCreate.UseVisualStyleBackColor = true;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(25, 33);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 7;
            this.BtnBack.Text = "Retour";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // ComboType
            // 
            this.ComboType.FormattingEnabled = true;
            this.ComboType.Location = new System.Drawing.Point(411, 250);
            this.ComboType.Name = "ComboType";
            this.ComboType.Size = new System.Drawing.Size(121, 21);
            this.ComboType.TabIndex = 8;
            // 
            // FormProductCreate
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
            this.Controls.Add(this.TxtPrix);
            this.Controls.Add(this.TxtLibelle);
            this.Name = "FormProductCreate";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoFact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtLibelle;
        private System.Windows.Forms.TextBox TxtPrix;
        private System.Windows.Forms.Label LabelLibelle;
        private System.Windows.Forms.Label LabelPrix;
        private System.Windows.Forms.Label LabelIdType;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.ComboBox ComboType;
    }
}