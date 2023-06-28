namespace GONSA
{
    partial class fTrangThaiGiaoHang
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
            control = new controlTrangThaiGiaoHang();
            btnImport = new Button();
            btnExport = new Button();
            SuspendLayout();
            // 
            // control
            // 
            control.Location = new Point(0, 0);
            control.Name = "control";
            control.Size = new Size(1080, 585);
            control.TabIndex = 0;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(57, 606);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(99, 46);
            btnImport.TabIndex = 1;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(220, 606);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(99, 46);
            btnExport.TabIndex = 1;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // fTrangThaiGiaoHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 682);
            Controls.Add(btnExport);
            Controls.Add(btnImport);
            Controls.Add(control);
            Name = "fTrangThaiGiaoHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fTrangThaiDonHang";
            ResumeLayout(false);
        }

        #endregion

        private controlTrangThaiGiaoHang control;
        private Button btnImport;
        private Button btnExport;
    }
}