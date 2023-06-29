using DTO;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace GONSA
{
    public partial class fTrangThaiGiaoHang : Form
    {
        public fTrangThaiGiaoHang()
        {
            InitializeComponent();
        }
        private void ExportToExcel()
        {
            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new SaveFileDialog();

            // chỉ lọc ra các file có định dạng Excel
            dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
            }

            // nếu đường dẫn null hoặc rỗng thì báo không hợp lệ và return hàm
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Đường dẫn báo cáo không hợp lệ");
                return;
            }
            BindingList<TrangThaiGiaoHangDTO> list = control.GetListTrangThaiGiaoHang();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage pck = new ExcelPackage())
            {
                pck.Workbook.Worksheets.Add("Trạng thái giao hàng").Cells[1, 1].LoadFromCollection(list,true);
                pck.SaveAs(new FileInfo(filePath));
            }
        }
        private void ImportFromExcel()
        {
            BindingList<TrangThaiGiaoHangDTO> list = new BindingList<TrangThaiGiaoHangDTO>();
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                // Sử dụng OpenFileDialog để lấy đường dẫn file Excel
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    // mở file excel
                    var package = new ExcelPackage(new FileInfo(filePath));

                    // lấy ra sheet đầu tiên để thao tác
                    ExcelWorksheet workSheet = package.Workbook.Worksheets[0];

                    // duyệt từng dòng từ dòng thứ 2 đến dòng cuối cùng của file (lưu ý file excel bắt đầu từ số 1 không phải số 0)
                    for (int i = workSheet.Dimension.Start.Row + 1; i <= workSheet.Dimension.End.Row; i++)
                    {
                        try
                        {
                            // biến j biểu thị cho một cột trong file
                            int j = 1;

                            // lấy ra cột mã trạng thái tương ứng giá trị tại vị trí [i, 1]. Lần đầu i là 2
                            // tăng j lên 1 đơn vị sau khi thực hiện xong câu lệnh
                            string maTrangThai = "";
                            string tenTrangThai = "";
                            string moTa = "";

                            var maTrangThai_tmp = workSheet.Cells[i, j++].Value?.ToString();
                            if (maTrangThai_tmp != null)
                            {
                                maTrangThai = maTrangThai_tmp;
                            }

                            var tenTrangThai_tmp = workSheet.Cells[i, j++].Value?.ToString();
                            if (tenTrangThai_tmp != null)
                            {
                                tenTrangThai = tenTrangThai_tmp;
                            }

                            var moTa_tmp = workSheet.Cells[i, j++].Value?.ToString();
                            if (moTa_tmp != null)
                            {
                                moTa = moTa_tmp;
                            }

                            TrangThaiGiaoHangDTO trangthai = new TrangThaiGiaoHangDTO(maTrangThai, tenTrangThai, moTa);

                            // Add vào list
                            list.Add(trangthai);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error on row " + i + ": " + ex.Message);
                        }
                    }

                    // Đóng package
                    package.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            control.AddDataWhenImport(list);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ImportFromExcel();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }
    }
}
