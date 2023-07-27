using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
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
        public TextBox GetTextBox()
        {
            return textBox1;
        }

        public controlTextBox()
        {
            InitializeComponent();
        }

        public new string Text
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }

        #region Methods
        private string RemoveCommaFromText(string input)
        {
            return input.Replace(",", "");
        }
        void DecimalNumber()
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

        void DecimalNumber_2()
        {
            string input = RemoveCommaFromText(textBox1.Text);

            string[] parts = input.Split('.',2);

            string secondPart = "";
            if (parts.Length == 2)
            {
                input = parts[0];    //Phần nguyên
                secondPart = "." + parts[1];   // Phần phân số
            }

            StringBuilder result = new StringBuilder(input);
            int count = 1;

            for (int i = input.Length - 1; i >= 0 ; i--)
            {
                if (input.Length < 4)
                {
                    textBox1.Text = input + secondPart;
                    return;
                }
                if (input[i].Equals(','))
                {
                    count = 1;
                    continue;
                }

                if (count == 3 && i>0)
                {
                    result = result.Insert(i, ",");
                    count = 1;
                }
                else
                {
                    count++;
                }
            }
                
            string outputText = result.ToString();

            textBox1.TextChanged -= textBox1_TextChanged;
            textBox1.Text = result.ToString() + secondPart ;
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.TextChanged += textBox1_TextChanged;
        }
        #endregion
        
        #region Events
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text.Contains(".") && e.KeyChar == '.')
            {
                e.Handled = true; // không cho nhập dấu chấm nữa
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back )
            {
                e.Handled = true;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DecimalNumber_2();
        }
        #endregion
    }
}
