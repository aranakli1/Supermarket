namespace Supermarket.View
{
    partial class CategoriesForm
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
            DgCategories = new DataGridView();
            IdCategory = new DataGridViewTextBoxColumn();
            NameCategory = new DataGridViewTextBoxColumn();
            DescCategory = new DataGridViewTextBoxColumn();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDesc = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategories).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnClose);
            groupBox2.Controls.Add(BtnDelete);
            groupBox2.Controls.Add(BtnEdit);
            groupBox2.Controls.Add(BtnNew);
            groupBox2.Location = new Point(617, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(171, 399);
            groupBox2.TabIndex = 21;
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
            BtnDelete.Click += BtnDelete_Click;
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
            // DgCategories
            // 
            DgCategories.AllowUserToAddRows = false;
            DgCategories.AllowUserToDeleteRows = false;
            DgCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategories.Columns.AddRange(new DataGridViewColumn[] { IdCategory, NameCategory, DescCategory });
            DgCategories.Location = new Point(12, 209);
            DgCategories.Name = "DgCategories";
            DgCategories.ReadOnly = true;
            DgCategories.RowHeadersWidth = 51;
            DgCategories.RowTemplate.Height = 29;
            DgCategories.Size = new Size(599, 216);
            DgCategories.TabIndex = 20;
            DgCategories.Click += DgCategories_Click;
            // 
            // IdCategory
            // 
            IdCategory.HeaderText = "Id";
            IdCategory.MinimumWidth = 6;
            IdCategory.Name = "IdCategory";
            IdCategory.ReadOnly = true;
            IdCategory.Resizable = DataGridViewTriState.False;
            IdCategory.Width = 125;
            // 
            // NameCategory
            // 
            NameCategory.HeaderText = "Name";
            NameCategory.MinimumWidth = 6;
            NameCategory.Name = "NameCategory";
            NameCategory.ReadOnly = true;
            NameCategory.Resizable = DataGridViewTriState.False;
            NameCategory.Width = 200;
            // 
            // DescCategory
            // 
            DescCategory.HeaderText = "Description";
            DescCategory.MinimumWidth = 6;
            DescCategory.Name = "DescCategory";
            DescCategory.ReadOnly = true;
            DescCategory.Resizable = DataGridViewTriState.False;
            DescCategory.Width = 220;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 141);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 18;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 98);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 17;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 55);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 16;
            label1.Text = "Id";
            // 
            // txtDesc
            // 
            txtDesc.Enabled = false;
            txtDesc.Location = new Point(161, 138);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(292, 27);
            txtDesc.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(161, 95);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Category Name";
            txtName.Size = new Size(207, 27);
            txtName.TabIndex = 14;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(161, 52);
            txtId.Name = "txtId";
            txtId.Size = new Size(207, 27);
            txtId.TabIndex = 13;
            txtId.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(33, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(439, 160);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data";
            // 
            // CategoriesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(groupBox2);
            Controls.Add(DgCategories);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDesc);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CategoriesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categories Management";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgCategories;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDesc;
        private TextBox txtName;
        private TextBox txtId;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn IdCategory;
        private DataGridViewTextBoxColumn NameCategory;
        private DataGridViewTextBoxColumn DescCategory;
    }
}