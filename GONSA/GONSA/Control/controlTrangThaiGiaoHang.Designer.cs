namespace GONSA
{
    partial class controlTrangThaiGiaoHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            txtSearch = new TextBox();
            label2 = new Label();
            txtTenTrangThai = new TextBox();
            dtgvTrangThaiGiaoHang = new DataGridView();
            colMa = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colMoTa = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtMaTrangThaiGiaoHang = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            panel1 = new Panel();
            label3 = new Label();
            txtMoTa = new RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTrangThaiGiaoHang).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(txtSearch, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(txtTenTrangThai, 1, 3);
            tableLayoutPanel1.Controls.Add(dtgvTrangThaiGiaoHang, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(txtMaTrangThaiGiaoHang, 1, 2);
            tableLayoutPanel1.Controls.Add(btnAdd, 0, 4);
            tableLayoutPanel1.Controls.Add(btnDelete, 1, 4);
            tableLayoutPanel1.Controls.Add(btnEdit, 2, 4);
            tableLayoutPanel1.Controls.Add(btnSave, 3, 4);
            tableLayoutPanel1.Controls.Add(panel1, 2, 2);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.678982F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65.9829F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.49572659F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.6239319F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.08547F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1080, 585);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtSearch
            // 
            tableLayoutPanel1.SetColumnSpan(txtSearch, 4);
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(3, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(1074, 23);
            txtSearch.TabIndex = 1;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 457);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 3;
            label2.Text = "Tên trạng thái";
            // 
            // txtTenTrangThai
            // 
            txtTenTrangThai.Location = new Point(273, 460);
            txtTenTrangThai.Name = "txtTenTrangThai";
            txtTenTrangThai.Size = new Size(202, 23);
            txtTenTrangThai.TabIndex = 10;
            // 
            // dtgvTrangThaiGiaoHang
            // 
            dtgvTrangThaiGiaoHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvTrangThaiGiaoHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTrangThaiGiaoHang.Columns.AddRange(new DataGridViewColumn[] { colMa, colName, colMoTa });
            tableLayoutPanel1.SetColumnSpan(dtgvTrangThaiGiaoHang, 4);
            dtgvTrangThaiGiaoHang.Dock = DockStyle.Fill;
            dtgvTrangThaiGiaoHang.Location = new Point(3, 36);
            dtgvTrangThaiGiaoHang.MultiSelect = false;
            dtgvTrangThaiGiaoHang.Name = "dtgvTrangThaiGiaoHang";
            dtgvTrangThaiGiaoHang.ReadOnly = true;
            dtgvTrangThaiGiaoHang.RowTemplate.Height = 25;
            dtgvTrangThaiGiaoHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvTrangThaiGiaoHang.Size = new Size(1074, 380);
            dtgvTrangThaiGiaoHang.TabIndex = 0;
            // 
            // colMa
            // 
            colMa.DataPropertyName = "MaTrangThaiGiaoHang";
            colMa.HeaderText = "Mã trạng thái";
            colMa.Name = "colMa";
            colMa.ReadOnly = true;
            // 
            // colName
            // 
            colName.DataPropertyName = "TenTrangThai";
            colName.HeaderText = "Tên trạng thái";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colMoTa
            // 
            colMoTa.DataPropertyName = "MoTa";
            colMoTa.HeaderText = "Mô tả";
            colMoTa.Name = "colMoTa";
            colMoTa.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 419);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 2;
            label1.Text = "Mã trạng thái giao hàng";
            // 
            // txtMaTrangThaiGiaoHang
            // 
            txtMaTrangThaiGiaoHang.Location = new Point(273, 422);
            txtMaTrangThaiGiaoHang.Name = "txtMaTrangThaiGiaoHang";
            txtMaTrangThaiGiaoHang.Size = new Size(202, 23);
            txtMaTrangThaiGiaoHang.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Location = new Point(3, 528);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(264, 54);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Location = new Point(273, 528);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(264, 54);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.Location = new Point(543, 528);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(264, 54);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Location = new Point(813, 528);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(264, 54);
            btnSave.TabIndex = 8;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel1
            // 
            tableLayoutPanel1.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtMoTa);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(543, 422);
            panel1.Name = "panel1";
            tableLayoutPanel1.SetRowSpan(panel1, 2);
            panel1.Size = new Size(534, 100);
            panel1.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 3);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(0, 21);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(534, 93);
            txtMoTa.TabIndex = 11;
            txtMoTa.Text = "";
            // 
            // controlTrangThaiGiaoHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "controlTrangThaiGiaoHang";
            Size = new Size(1080, 585);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTrangThaiGiaoHang).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dtgvTrangThaiGiaoHang;
        private TextBox txtSearch;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSave;
        private TextBox txtMaTrangThaiGiaoHang;
        private TextBox txtTenTrangThai;
        private RichTextBox txtMoTa;
        private Panel panel1;
        private DataGridViewTextBoxColumn colMa;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colMoTa;
    }
}
