using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class customizeControlFunction : Form
    {

        public customizeControlFunction()
        {
            InitializeComponent();


            Binding dataBinding = new Binding("Text", controlTextBox1.GetTextBox(), "Text", true, DataSourceUpdateMode.Never);
            controlTextBox2.DataBindings.Add(dataBinding);

        }

        private string RemoveCommaFromText(string input)
        {
            return input.Replace(",", "");
        }

    }
}
