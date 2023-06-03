namespace AutoFact2
{
    partial class FormProductList
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
            this.DgvProduct = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLibel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIdCateg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBtnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColBtnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProduct
            // 
            this.DgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColLibel,
            this.ColPrice,
            this.ColIdCateg,
            this.ColBtnUpdate,
            this.ColBtnDelete});
            this.DgvProduct.Location = new System.Drawing.Point(28, 108);
            this.DgvProduct.Name = "DgvProduct";
            this.DgvProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DgvProduct.Size = new System.Drawing.Size(682, 150);
            this.DgvProduct.TabIndex = 0;
            this.DgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProduct_CellContentClick);
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            // 
            // ColLibel
            // 
            this.ColLibel.HeaderText = "Libel";
            this.ColLibel.Name = "ColLibel";
            // 
            // ColPrice
            // 
            this.ColPrice.HeaderText = "Prix unitaire";
            this.ColPrice.Name = "ColPrice";
            this.ColPrice.ReadOnly = true;
            // 
            // ColIdCateg
            // 
            this.ColIdCateg.HeaderText = "IdCategorie";
            this.ColIdCateg.Name = "ColIdCateg";
            this.ColIdCateg.ReadOnly = true;
            // 
            // ColBtnUpdate
            // 
            this.ColBtnUpdate.HeaderText = "Update";
            this.ColBtnUpdate.Name = "ColBtnUpdate";
            // 
            // ColBtnDelete
            // 
            this.ColBtnDelete.HeaderText = "Delete";
            this.ColBtnDelete.Name = "ColBtnDelete";
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(28, 31);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "Retour";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(28, 332);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(75, 23);
            this.BtnCreate.TabIndex = 2;
            this.BtnCreate.Text = "Créer";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // FormProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.DgvProduct);
            this.Name = "FormProductList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoFact";
            this.Load += new System.EventHandler(this.FormProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLibel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdCateg;
        private System.Windows.Forms.DataGridViewButtonColumn ColBtnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn ColBtnDelete;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnCreate;
    }
}