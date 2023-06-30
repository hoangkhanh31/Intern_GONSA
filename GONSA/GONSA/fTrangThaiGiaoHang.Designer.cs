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
            btnImportExcel = new Button();
            btnExportExcel = new Button();
            btnExportXML = new Button();
            btnDecodeXml = new Button();
            SuspendLayout();
            // 
            // control
            // 
            control.Location = new Point(0, 0);
            control.Name = "control";
            control.Size = new Size(1080, 585);
            control.TabIndex = 0;
            // 
            // btnImportExcel
            // 
            btnImportExcel.Location = new Point(57, 606);
            btnImportExcel.Name = "btnImportExcel";
            btnImportExcel.Size = new Size(99, 46);
            btnImportExcel.TabIndex = 1;
            btnImportExcel.Text = "Import Excel";
            btnImportExcel.UseVisualStyleBackColor = true;
            btnImportExcel.Click += btnImport_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Location = new Point(220, 606);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(99, 46);
            btnExportExcel.TabIndex = 1;
            btnExportExcel.Text = "Export Excel";
            btnExportExcel.UseVisualStyleBackColor = true;
            btnExportExcel.Click += btnExport_Click;
            // 
            // btnExportXML
            // 
            btnExportXML.Location = new Point(407, 606);
            btnExportXML.Name = "btnExportXML";
            btnExportXML.Size = new Size(104, 46);
            btnExportXML.TabIndex = 2;
            btnExportXML.Text = "Export XML";
            btnExportXML.UseVisualStyleBackColor = true;
            btnExportXML.Click += btnExportXML_Click;
            // 
            // btnDecodeXml
            // 
            btnDecodeXml.Location = new Point(546, 606);
            btnDecodeXml.Name = "btnDecodeXml";
            btnDecodeXml.Size = new Size(104, 46);
            btnDecodeXml.TabIndex = 2;
            btnDecodeXml.Text = "Decode XML";
            btnDecodeXml.UseVisualStyleBackColor = true;
            btnDecodeXml.Click += btnDecodeXml_Click;
            // 
            // fTrangThaiGiaoHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 682);
            Controls.Add(btnDecodeXml);
            Controls.Add(btnExportXML);
            Controls.Add(btnExportExcel);
            Controls.Add(btnImportExcel);
            Controls.Add(control);
            Name = "fTrangThaiGiaoHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fTrangThaiDonHang";
            ResumeLayout(false);
        }

        #endregion

        private controlTrangThaiGiaoHang control;
        private Button btnImportExcel;
        private Button btnExportExcel;
        private Button btnExportXML;
        private Button btnDecodeXml;
    }
}