using BLL;
using DTO;
using System.ComponentModel;

namespace GONSA
{
    public partial class controlTrangThaiGiaoHang : UserControl
    {
        private bool EnableEdit = false;
        private static TrangThaiGiaoHangBUS TrangThaiGiaoHangBUS = new TrangThaiGiaoHangBUS();
        private BindingList<TrangThaiGiaoHangDTO> list = new BindingList<TrangThaiGiaoHangDTO>(TrangThaiGiaoHangBUS.GetList());
        //private List<TrangThaiGiaoHangDTO> list1 = TrangThaiGiaoHangBUS.GetList();
        public controlTrangThaiGiaoHang()
        {
            InitializeComponent();
            EditState(EnableEdit);
            dtgvTrangThaiGiaoHang.DataSource = list;
            Binding();
        }

        #region Methods
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
        #endregion

        #region Events
        private void LoadData()
        {
            dtgvTrangThaiGiaoHang.DataSource = null;
            dtgvTrangThaiGiaoHang.DataSource = list;
        }
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
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dtgvTrangThaiGiaoHang.SelectedRows)
            {
                dtgvTrangThaiGiaoHang.Rows.RemoveAt(item.Index);
            }
        }
        #endregion


        private void btnSave_Click(object sender, EventArgs e)
        {

            string tenTrangThai = txtTenTrangThai.Text;
            string moTa = txtMoTa.Text;

            foreach (DataGridViewRow item in dtgvTrangThaiGiaoHang.SelectedRows)
            {
                item.Cells["Mã trạng thái"].Value = txtMaTrangThaiGiaoHang.Text;

            }
        }
    }
}
