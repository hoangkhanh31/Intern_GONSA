namespace CongNo
{
    partial class controlCongNo
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txbMaKHB2B = new TextBox();
            txbMaCongNo = new TextBox();
            dtpkCongNo = new DateTimePicker();
            textBox3 = new TextBox();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(txbMaKHB2B, 1, 0);
            tableLayoutPanel1.Controls.Add(txbMaCongNo, 1, 1);
            tableLayoutPanel1.Controls.Add(dtpkCongNo, 1, 2);
            tableLayoutPanel1.Controls.Add(textBox3, 1, 3);
            tableLayoutPanel1.Controls.Add(richTextBox1, 1, 4);
            tableLayoutPanel1.Controls.Add(richTextBox2, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(748, 347);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(218, 40);
            label1.TabIndex = 0;
            label1.Text = "Mã khách hàng B2B";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 40);
            label2.Name = "label2";
            label2.Size = new Size(218, 40);
            label2.TabIndex = 0;
            label2.Text = "Mã công nợ";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 80);
            label3.Name = "label3";
            label3.Size = new Size(218, 40);
            label3.TabIndex = 0;
            label3.Text = "Thời hạn công nợ";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 120);
            label4.Name = "label4";
            label4.Size = new Size(218, 40);
            label4.TabIndex = 0;
            label4.Text = "Hạn mức công nợ";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 160);
            label5.Name = "label5";
            label5.Size = new Size(218, 40);
            label5.TabIndex = 0;
            label5.Text = "Đánh giá";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 200);
            label6.Name = "label6";
            label6.Size = new Size(218, 147);
            label6.TabIndex = 0;
            label6.Text = "Ghi chú";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbMaKHB2B
            // 
            txbMaKHB2B.Dock = DockStyle.Fill;
            txbMaKHB2B.Location = new Point(227, 3);
            txbMaKHB2B.Name = "txbMaKHB2B";
            txbMaKHB2B.Size = new Size(518, 23);
            txbMaKHB2B.TabIndex = 1;
            txbMaKHB2B.KeyPress += txbMaKHB2B_KeyPress;
            // 
            // txbMaCongNo
            // 
            txbMaCongNo.Dock = DockStyle.Fill;
            txbMaCongNo.Location = new Point(227, 43);
            txbMaCongNo.Name = "txbMaCongNo";
            txbMaCongNo.Size = new Size(518, 23);
            txbMaCongNo.TabIndex = 2;
            txbMaCongNo.KeyPress += txbMaCongNo_KeyPress;
            // 
            // dtpkCongNo
            // 
            dtpkCongNo.Dock = DockStyle.Fill;
            dtpkCongNo.Location = new Point(227, 83);
            dtpkCongNo.Name = "dtpkCongNo";
            dtpkCongNo.Size = new Size(518, 23);
            dtpkCongNo.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Fill;
            textBox3.Location = new Point(227, 123);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(518, 23);
            textBox3.TabIndex = 4;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(227, 163);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(518, 34);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Dock = DockStyle.Fill;
            richTextBox2.Location = new Point(227, 203);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(518, 141);
            richTextBox2.TabIndex = 6;
            richTextBox2.Text = "";
            // 
            // controlCongNo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "controlCongNo";
            Size = new Size(748, 347);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txbMaKHB2B;
        private TextBox txbMaCongNo;
        private DateTimePicker dtpkCongNo;
        private TextBox textBox3;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
    }
}
