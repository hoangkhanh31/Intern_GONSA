using DAL.Models;
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
    public partial class fGonsaEntityFramework : Form
    {
        public fGonsaEntityFramework()
        {
            InitializeComponent();

            LoadDTGVCBNV();
            LoadDTGVUser();
        }

        void LoadDTGVCBNV()
        {
            using (var db = new GonsaContext())
            {
                var data = from c in db.CbnvGonsas select c;

                if (data != null)
                {
                    if (data.Count() > 0)
                    {
                        dtgvCBNV.DataSource = data.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Không có record");
                        dtgvCBNV.DataSource = null;
                    }
                }
            }
        }

        void LoadDTGVUser()
        {
            using (var db = new GonsaContext())
            {
                var data = from c in db.UserMiddlewares select c;

                if (data != null)
                {
                    if (data.Count() > 0)
                    {
                        dtgvUser.DataSource = data.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Không có record");
                        dtgvUser.DataSource = null;
                    }
                }
            }
        }
    }
}
