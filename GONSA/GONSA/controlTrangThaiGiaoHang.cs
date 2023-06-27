using BLL;
using DTO;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GONSA
{
    public partial class controlTrangThaiGiaoHang : UserControl
    {
        private bool EnableEdit = false;
        private static TrangThaiGiaoHangBUS TrangThaiGiaoHangBUS = new TrangThaiGiaoHangBUS();
        private BindingList<TrangThaiGiaoHangDTO> list = new BindingList<TrangThaiGiaoHangDTO>(TrangThaiGiaoHangBUS.GetList());
        public controlTrangThaiGiaoHang()
        {
            InitializeComponent();
            EditState(EnableEdit);
            dtgvTrangThaiGiaoHang.DataSource = list;
            Binding();
        }

        #region Methods
        private void Reload()
        {

            dtgvTrangThaiGiaoHang.DataSource = list;
        }
        private void EditState(bool type)
        {
            txtMaTrangThaiGiaoHang.Enabled = type;
            txtTenTrangThai.Enabled = type;
            txtMoTa.Enabled = type;
        }
        private void Clear()
        {
            txtMaTrangThaiGiaoHang.Text = "";
            txtMoTa.Text = "";
            txtTenTrangThai.Text = "";
        }
        private void Binding()
        {
            txtMaTrangThaiGiaoHang.DataBindings.Add("Text", dtgvTrangThaiGiaoHang.DataSource, "MaTrangThaiGiaoHang", true, DataSourceUpdateMode.Never);
            txtTenTrangThai.DataBindings.Add("Text", dtgvTrangThaiGiaoHang.DataSource, "TenTrangThai", true, DataSourceUpdateMode.Never);
            txtMoTa.DataBindings.Add("Text", dtgvTrangThaiGiaoHang.DataSource, "MoTa", true, DataSourceUpdateMode.Never);
        }
        public static DataTable ConvertToDataTable<T>(BindingList<T> bindingList)
        {
            DataTable dataTable = new DataTable();

            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));

            foreach (PropertyDescriptor prop in properties)
            {
                dataTable.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (T item in bindingList)
            {
                DataRow row = dataTable.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
        #endregion

        #region Events

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!EnableEdit)
            {
                EnableEdit = true;
                EditState(EnableEdit);
            }
            else
            {
                EnableEdit = false;
                EditState(EnableEdit);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maTrangThaiGiaoHang = txtMaTrangThaiGiaoHang.Text;
            string tenTrangThai = txtTenTrangThai.Text;
            string moTa = txtMoTa.Text;

            list.Add(new TrangThaiGiaoHangDTO(maTrangThaiGiaoHang, tenTrangThai, moTa));
            Reload();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dtgvTrangThaiGiaoHang.SelectedRows)
            {
                dtgvTrangThaiGiaoHang.Rows.RemoveAt(item.Index);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dtgvTrangThaiGiaoHang.SelectedRows)
            {
                item.Cells[0].Value = txtMaTrangThaiGiaoHang.Text;
                item.Cells[1].Value = txtTenTrangThai.Text;
                item.Cells[2].Value = txtMoTa.Text;
            }
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            var dt = ConvertToDataTable(list);
            DataView dv = dt.DefaultView;
            dv.RowFilter = String.Format("MaTrangThaiGiaoHang LIKE '%{0}%' " +
                "OR TenTrangThai LIKE '%{0}%'", txtSearch.Text);
            dtgvTrangThaiGiaoHang.DataSource = dv;

        }
        #endregion

    }
}
