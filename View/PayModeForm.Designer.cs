namespace Supermarket.View
{
    partial class PayModeForm
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
            txtId = new TextBox();
            txtName = new TextBox();
            txtObserv = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            DgPayMode = new DataGridView();
            IdPaymode = new DataGridViewTextBoxColumn();
            NamePayMode = new DataGridViewTextBoxColumn();
            ObservPayMode = new DataGridViewTextBoxColumn();
            BtnNew = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnClose = new Button();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(161, 65);
            txtId.Name = "txtId";
            txtId.Size = new Size(207, 27);
            txtId.TabIndex = 0;
            txtId.TextAlign = HorizontalAlignment.Right;
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(161, 108);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Pay mode name";
            txtName.Size = new Size(207, 27);
            txtName.TabIndex = 1;
            // 
            // txtObserv
            // 
            txtObserv.Enabled = false;
            txtObserv.Location = new Point(161, 151);
            txtObserv.Name = "txtObserv";
            txtObserv.Size = new Size(292, 27);
            txtObserv.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 68);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 3;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 111);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 154);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 5;
            label3.Text = "Observation";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(33, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(439, 160);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data";
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Columns.AddRange(new DataGridViewColumn[] { IdPaymode, NamePayMode, ObservPayMode });
            DgPayMode.Location = new Point(12, 222);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.RowHeadersWidth = 51;
            DgPayMode.RowTemplate.Height = 29;
            DgPayMode.Size = new Size(599, 216);
            DgPayMode.TabIndex = 7;
            DgPayMode.Click += DgPayMode_Click;
            // 
            // IdPaymode
            // 
            IdPaymode.HeaderText = "Id";
            IdPaymode.MinimumWidth = 6;
            IdPaymode.Name = "IdPaymode";
            IdPaymode.ReadOnly = true;
            IdPaymode.Resizable = DataGridViewTriState.False;
            IdPaymode.Width = 125;
            // 
            // NamePayMode
            // 
            NamePayMode.HeaderText = "Name";
            NamePayMode.MinimumWidth = 6;
            NamePayMode.Name = "NamePayMode";
            NamePayMode.ReadOnly = true;
            NamePayMode.Resizable = DataGridViewTriState.False;
            NamePayMode.Width = 200;
            // 
            // ObservPayMode
            // 
            ObservPayMode.HeaderText = "Observation";
            ObservPayMode.MinimumWidth = 6;
            ObservPayMode.Name = "ObservPayMode";
            ObservPayMode.ReadOnly = true;
            ObservPayMode.Resizable = DataGridViewTriState.False;
            ObservPayMode.Width = 250;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnClose);
            groupBox2.Controls.Add(BtnDelete);
            groupBox2.Controls.Add(BtnEdit);
            groupBox2.Controls.Add(BtnNew);
            groupBox2.Location = new Point(617, 39);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(171, 399);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Commands";
            // 
            // PayModeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(groupBox2);
            Controls.Add(DgPayMode);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtObserv);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PayModeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pay Mode Management";
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtObserv;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private DataGridView DgPayMode;
        private Button BtnNew;
        private DataGridViewTextBoxColumn IdPaymode;
        private DataGridViewTextBoxColumn NamePayMode;
        private DataGridViewTextBoxColumn ObservPayMode;
        private Button BtnEdit;
        private Button BtnDelete;
        private Button BtnClose;
        private GroupBox groupBox2;
    }
}