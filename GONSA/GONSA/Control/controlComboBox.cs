using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GUI.Control
{
    public partial class controlComboBox : UserControl
    {
        private bool enabledRead = false;
        private string initialValue;

        public controlComboBox()
        {
            InitializeComponent();

            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");

            comboBox1.DataSource = cities;
            comboBox1.SelectedIndex = 2;
            
            initialValue = comboBox1.Text;
            RestoreInitialValue();
        }
        
        //Properties
        [Category("My Custom")]
        public bool EnabledRead
        {
            get { return enabledRead; }
            set
            {
                enabledRead = value;
            }
        }

        private void RestoreInitialValue()
        {
            comboBox1.Text = initialValue;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (enabledRead == true)
            {
                comboBox1.Text = initialValue;
            }    
        }
    }
}
