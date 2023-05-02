namespace AutoFact2
{
    partial class FormClientList
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
            this.DgvClient = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAdresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBtnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColBtnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnCreateClient = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClient)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvClient
            // 
            this.DgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColName,
            this.ColSurname,
            this.ColCompany,
            this.ColAdresse,
            this.ColPostalCode,
            this.ColCity,
            this.ColMail,
            this.ColTel,
            this.ColBtnUpdate,
            this.ColBtnDelete});
            this.DgvClient.Location = new System.Drawing.Point(12, 137);
            this.DgvClient.Name = "DgvClient";
            this.DgvClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DgvClient.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.DgvClient.Size = new System.Drawing.Size(1150, 150);
            this.DgvClient.TabIndex = 0;
            this.DgvClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Prénom";
            this.ColName.Name = "ColName";
            // 
            // ColSurname
            // 
            this.ColSurname.HeaderText = "Nom";
            this.ColSurname.Name = "ColSurname";
            this.ColSurname.ReadOnly = true;
            // 
            // ColCompany
            // 
            this.ColCompany.HeaderText = "Nom compagnie";
            this.ColCompany.Name = "ColCompany";
            this.ColCompany.ReadOnly = true;
            // 
            // ColAdresse
            // 
            this.ColAdresse.HeaderText = "Adresse";
            this.ColAdresse.Name = "ColAdresse";
            this.ColAdresse.ReadOnly = true;
            // 
            // ColPostalCode
            // 
            this.ColPostalCode.HeaderText = "Code Postal";
            this.ColPostalCode.Name = "ColPostalCode";
            this.ColPostalCode.ReadOnly = true;
            // 
            // ColCity
            // 
            this.ColCity.HeaderText = "Ville";
            this.ColCity.Name = "ColCity";
            this.ColCity.ReadOnly = true;
            // 
            // ColMail
            // 
            this.ColMail.HeaderText = "Mail";
            this.ColMail.Name = "ColMail";
            this.ColMail.ReadOnly = true;
            // 
            // ColTel
            // 
            this.ColTel.HeaderText = "Telephone";
            this.ColTel.Name = "ColTel";
            this.ColTel.ReadOnly = true;
            // 
            // ColBtnUpdate
            // 
            this.ColBtnUpdate.HeaderText = "Update";
            this.ColBtnUpdate.Name = "ColBtnUpdate";
            this.ColBtnUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColBtnUpdate.Text = "Update";
            // 
            // ColBtnDelete
            // 
            this.ColBtnDelete.HeaderText = "Delete";
            this.ColBtnDelete.Name = "ColBtnDelete";
            this.ColBtnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColBtnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColBtnDelete.Text = "Delete";
            // 
            // BtnCreateClient
            // 
            this.BtnCreateClient.Location = new System.Drawing.Point(12, 316);
            this.BtnCreateClient.Name = "BtnCreateClient";
            this.BtnCreateClient.Size = new System.Drawing.Size(75, 23);
            this.BtnCreateClient.TabIndex = 1;
            this.BtnCreateClient.Text = "Create";
            this.BtnCreateClient.UseVisualStyleBackColor = true;
            this.BtnCreateClient.Click += new System.EventHandler(this.BtnCreateClient_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(12, 13);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "retour";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // FormClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnCreateClient);
            this.Controls.Add(this.DgvClient);
            this.Name = "FormClientList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoFact";
            ((System.ComponentModel.ISupportInitialize)(this.DgvClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAdresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTel;
        private System.Windows.Forms.DataGridViewButtonColumn ColBtnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn ColBtnDelete;
        private System.Windows.Forms.Button BtnCreateClient;
        private System.Windows.Forms.Button BtnBack;
    }
}