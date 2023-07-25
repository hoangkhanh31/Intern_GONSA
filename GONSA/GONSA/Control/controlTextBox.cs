using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class controlTextBox : UserControl
    {
        public controlTextBox()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                // Tách phần nguyên và phần thập phân của số
                string[] parts = textBox1.Text.Split('.');
                string integerPart = parts[0];
                string decimalPart = parts.Length > 1 ? "." + parts[1] : "";

                // Loại bỏ các dấu phẩy có thể có trong phần nguyên và chuyển đổi nó thành số
                if (long.TryParse(integerPart.Replace(",", ""), out long number))
                {
                    // Định dạng lại phần nguyên của số và thêm dấu phẩy
                    string formattedIntegerPart = string.Format("{0:#,##0}", number);

                    // Kết hợp phần nguyên và phần thập phân lại với nhau
                    textBox1.Text = formattedIntegerPart + decimalPart;
                    textBox1.SelectionStart = textBox1.Text.Length; // Đặt con trỏ về cuối TextBox
                }
            }
        }
    }
}
