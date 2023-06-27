namespace GONSA
{
    partial class fDonHangXuat
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnShow = new Button();
            btnClear = new Button();
            btnEdit = new Button();
            ctDonHangXuat = new controlDonHangXuat();
            SuspendLayout();
            // 
            // btnShow
            // 
            btnShow.Location = new Point(809, 421);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(83, 27);
            btnShow.TabIndex = 1;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(809, 463);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(83, 29);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(809, 512);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(83, 29);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // ctDonHangXuat
            // 
            ctDonHangXuat.Location = new Point(0, -1);
            ctDonHangXuat.Name = "ctDonHangXuat";
            ctDonHangXuat.Size = new Size(1080, 585);
            ctDonHangXuat.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 651);
            Controls.Add(btnEdit);
            Controls.Add(btnClear);
            Controls.Add(btnShow);
            Controls.Add(ctDonHangXuat);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button btnShow;
        private Button btnClear;
        private Button btnEdit;
        private controlDonHangXuat ctDonHangXuat;
    }
}