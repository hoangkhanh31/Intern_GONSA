using DTO;

namespace GONSA
{
    public partial class fDonHangXuat : Form
    {
        private bool EnableEdit = false;
        public fDonHangXuat()
        {
            InitializeComponent();
            ctDonHangXuat.EnableEdit(EnableEdit);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!EnableEdit)
            {
                EnableEdit = true;
                ctDonHangXuat.EnableEdit(EnableEdit);
            }
            else
            {
                EnableEdit = false;
                ctDonHangXuat.EnableEdit(EnableEdit);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ctDonHangXuat.ClearData();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            DonHangXuatDTO data = new DonHangXuatDTO();
            data.MaDonHang = "1";
            data.NgayKeToanDuyetCtu = new DateTime(2023, 1, 1);

            ctDonHangXuat.ShowData(data);
        }
    }
}