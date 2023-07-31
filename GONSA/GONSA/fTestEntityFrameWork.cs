using DAL.Models;
using DAL.TestModels;
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
    public partial class ftestEntityFrameWork : Form
    {
        public ftestEntityFrameWork()
        {
            InitializeComponent();
            
            LoadDTGV();
        }

        void LoadDTGV()
        {
            using (var db = new TestContext())
            {
                var sinhVienData = from c in db.SinhViens select c;

                if (sinhVienData != null) 
                {
                    if (sinhVienData.Count() > 0 )
                    {
                        dataGridView1.DataSource = sinhVienData.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Không có record sinh viên nào cả");
                        dataGridView1.DataSource = null;
                    }
                }
            }
        }
    }
}
