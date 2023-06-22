using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CongNo
{
    public partial class controlCongNo : UserControl
    {
        string maKH_B2B = "KH001";
        string maCongNo = "CN001";
        public controlCongNo()
        {
            InitializeComponent();
            DateTime today = DateTime.Today;
            dtpkCongNo.MinDate = DateTime.Now.AddDays(-30);
            dtpkCongNo.MaxDate = DateTime.Now.AddDays(+30);

        }

        private void txbMaKHB2B_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                checkMaKHB2B();
            }
        }
        void checkMaKHB2B()
        {
            string maKH_input = txbMaKHB2B.Text;
            if (!maKH_input.Equals(maKH_B2B))
            {
                MessageBox.Show("Mã khách hàng B2B không hợp lệ");
            }
        }

        private void txbMaCongNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                checkMaCongNo();
            }
        }
        void checkMaCongNo()
        {
            string maCN_input = txbMaCongNo.Text;
            if (!maCN_input.Equals(maCongNo))
            {
                MessageBox.Show("Mã công nợ không hợp lệ");
            }
        }
    }
}
