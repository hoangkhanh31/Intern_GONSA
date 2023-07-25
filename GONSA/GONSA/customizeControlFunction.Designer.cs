namespace GUI
{
    partial class customizeControlFunction
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
            controlTextBox1 = new controlTextBox();
            controlComboBox1 = new Control.controlComboBox();
            SuspendLayout();
            // 
            // controlTextBox1
            // 
            controlTextBox1.Location = new Point(270, 60);
            controlTextBox1.Name = "controlTextBox1";
            controlTextBox1.Size = new Size(161, 23);
            controlTextBox1.TabIndex = 0;
            // 
            // controlComboBox1
            // 
            controlComboBox1.EnabledRead = true;
            controlComboBox1.Location = new Point(270, 117);
            controlComboBox1.Name = "controlComboBox1";
            controlComboBox1.Size = new Size(191, 23);
            controlComboBox1.TabIndex = 1;
            // 
            // customizeControlFunction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(controlComboBox1);
            Controls.Add(controlTextBox1);
            Name = "customizeControlFunction";
            Text = "customFunctionControl";
            ResumeLayout(false);
        }

        #endregion

        private controlTextBox controlTextBox1;
        private Control.controlComboBox controlComboBox1;
    }
}