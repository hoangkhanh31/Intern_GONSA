namespace GUI
{
    partial class fGonsaEntityFramework
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
            dtgvCBNV = new DataGridView();
            dtgvUser = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgvCBNV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvUser).BeginInit();
            SuspendLayout();
            // 
            // dtgvCBNV
            // 
            dtgvCBNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCBNV.Location = new Point(17, 21);
            dtgvCBNV.Name = "dtgvCBNV";
            dtgvCBNV.RowTemplate.Height = 25;
            dtgvCBNV.Size = new Size(430, 237);
            dtgvCBNV.TabIndex = 0;
            // 
            // dtgvUser
            // 
            dtgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvUser.Location = new Point(533, 21);
            dtgvUser.Name = "dtgvUser";
            dtgvUser.RowTemplate.Height = 25;
            dtgvUser.Size = new Size(498, 237);
            dtgvUser.TabIndex = 1;
            // 
            // gonsaEntityFramework
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 555);
            Controls.Add(dtgvUser);
            Controls.Add(dtgvCBNV);
            Name = "gonsaEntityFramework";
            Text = "gonsaEntityFramework";
            ((System.ComponentModel.ISupportInitialize)dtgvCBNV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvCBNV;
        private DataGridView dtgvUser;
    }
}