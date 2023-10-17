namespace Supermarket.View
{
    partial class ProductsForm
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
            groupBox2 = new GroupBox();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgProducts = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            txtName = new TextBox();
            txtId = new TextBox();
            groupBox1 = new GroupBox();
            txtCatId = new TextBox();
            label5 = new Label();
            txtStock = new TextBox();
            txtPrice = new TextBox();
            label4 = new Label();
            label3 = new Label();
            IdProduct = new DataGridViewTextBoxColumn();
            NameProduct = new DataGridViewTextBoxColumn();
            PriceProduct = new DataGridViewTextBoxColumn();
            StockProduct = new DataGridViewTextBoxColumn();
            CatIdProduct = new DataGridViewTextBoxColumn();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProducts).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnClose);
            groupBox2.Controls.Add(BtnDelete);
            groupBox2.Controls.Add(BtnEdit);
            groupBox2.Controls.Add(BtnNew);
            groupBox2.Location = new Point(929, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(171, 399);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Commands";
            // 
            // BtnClose
            // 
            BtnClose.BackColor = SystemColors.AppWorkspace;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.ImageAlign = ContentAlignment.TopCenter;
            BtnClose.Location = new Point(6, 310);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(144, 74);
            BtnClose.TabIndex = 11;
            BtnClose.Text = "&Close";
            BtnClose.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnClose.UseVisualStyleBackColor = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = SystemColors.AppWorkspace;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.ImageAlign = ContentAlignment.TopCenter;
            BtnDelete.Location = new Point(6, 217);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(144, 76);
            BtnDelete.TabIndex = 10;
            BtnDelete.Text = "&Delete";
            BtnDelete.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnDelete.UseVisualStyleBackColor = false;
            // 
            // BtnEdit
            // 
            BtnEdit.BackColor = SystemColors.AppWorkspace;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.ImageAlign = ContentAlignment.TopCenter;
            BtnEdit.Location = new Point(6, 127);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(144, 72);
            BtnEdit.TabIndex = 9;
            BtnEdit.Text = "&Edit";
            BtnEdit.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnEdit.UseVisualStyleBackColor = false;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnNew
            // 
            BtnNew.BackColor = SystemColors.AppWorkspace;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.ImageAlign = ContentAlignment.TopCenter;
            BtnNew.Location = new Point(6, 30);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(144, 76);
            BtnNew.TabIndex = 8;
            BtnNew.Text = "&New";
            BtnNew.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnNew.UseVisualStyleBackColor = false;
            BtnNew.Click += BtnNew_Click;
            // 
            // DgProducts
            // 
            DgProducts.AllowUserToAddRows = false;
            DgProducts.AllowUserToDeleteRows = false;
            DgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProducts.Columns.AddRange(new DataGridViewColumn[] { IdProduct, NameProduct, PriceProduct, StockProduct, CatIdProduct });
            DgProducts.Location = new Point(12, 209);
            DgProducts.Name = "DgProducts";
            DgProducts.ReadOnly = true;
            DgProducts.RowHeadersWidth = 51;
            DgProducts.RowTemplate.Height = 29;
            DgProducts.Size = new Size(894, 216);
            DgProducts.TabIndex = 29;
            DgProducts.Click += DgProducts_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 62);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 26;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 55);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 25;
            label1.Text = "Id";
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(82, 59);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Category Name";
            txtName.Size = new Size(207, 27);
            txtName.TabIndex = 23;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(82, 26);
            txtId.Name = "txtId";
            txtId.Size = new Size(207, 27);
            txtId.TabIndex = 22;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCatId);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtId);
            groupBox1.Location = new Point(12, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(894, 160);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data";
            // 
            // txtCatId
            // 
            txtCatId.Location = new Point(367, 106);
            txtCatId.Name = "txtCatId";
            txtCatId.Size = new Size(125, 27);
            txtCatId.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(275, 109);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 31;
            label5.Text = "Category Id";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(367, 62);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(125, 27);
            txtStock.TabIndex = 30;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(367, 26);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 29;
            txtPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(320, 29);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 28;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(316, 62);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 27;
            label3.Text = "Stock";
            // 
            // IdProduct
            // 
            IdProduct.HeaderText = "Id";
            IdProduct.MinimumWidth = 6;
            IdProduct.Name = "IdProduct";
            IdProduct.ReadOnly = true;
            IdProduct.Resizable = DataGridViewTriState.False;
            IdProduct.Width = 125;
            // 
            // NameProduct
            // 
            NameProduct.HeaderText = "Name";
            NameProduct.MinimumWidth = 6;
            NameProduct.Name = "NameProduct";
            NameProduct.ReadOnly = true;
            NameProduct.Resizable = DataGridViewTriState.False;
            NameProduct.Width = 200;
            // 
            // PriceProduct
            // 
            PriceProduct.HeaderText = "Price";
            PriceProduct.MinimumWidth = 6;
            PriceProduct.Name = "PriceProduct";
            PriceProduct.ReadOnly = true;
            PriceProduct.Resizable = DataGridViewTriState.False;
            PriceProduct.Width = 125;
            // 
            // StockProduct
            // 
            StockProduct.HeaderText = "Stock";
            StockProduct.MinimumWidth = 6;
            StockProduct.Name = "StockProduct";
            StockProduct.ReadOnly = true;
            StockProduct.Resizable = DataGridViewTriState.False;
            StockProduct.Width = 125;
            // 
            // CatIdProduct
            // 
            CatIdProduct.HeaderText = "Cetegory Id";
            CatIdProduct.MinimumWidth = 6;
            CatIdProduct.Name = "CatIdProduct";
            CatIdProduct.ReadOnly = true;
            CatIdProduct.Resizable = DataGridViewTriState.False;
            CatIdProduct.Width = 125;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 450);
            ControlBox = false;
            Controls.Add(groupBox2);
            Controls.Add(DgProducts);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products Management";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgProducts).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgProducts;
        private Label label2;
        private Label label1;
        private TextBox txtName;
        private TextBox txtId;
        private GroupBox groupBox1;
        private Label label3;
        private Label label4;
        private TextBox txtCatId;
        private Label label5;
        private TextBox txtStock;
        private TextBox txtPrice;
        private DataGridViewTextBoxColumn IdCategory;
        private DataGridViewTextBoxColumn NameCategory;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn CatId;
        private DataGridViewTextBoxColumn IdProduct;
        private DataGridViewTextBoxColumn NameProduct;
        private DataGridViewTextBoxColumn PriceProduct;
        private DataGridViewTextBoxColumn StockProduct;
        private DataGridViewTextBoxColumn CatIdProduct;
    }
}