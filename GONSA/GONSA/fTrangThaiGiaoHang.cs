using DTO;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace GONSA
{
    public partial class fTrangThaiGiaoHang : Form
    {
        static string key { get; set; } = "A!9HHhi%XjjYY4YP2@Nob009X";
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
                pck.Workbook.Worksheets.Add("Trạng thái giao hàng").Cells[1, 1].LoadFromCollection(list, true);
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
                    control.AddDataWhenImport(list);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public static string Encrypt(string text)
        {
            using (var md5 = MD5.Create())
            {
                using (var tdes = TripleDES.Create())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateEncryptor())
                    {
                        byte[] textBytes = UTF8Encoding.UTF8.GetBytes(text);
                        byte[] bytes = transform.TransformFinalBlock(textBytes, 0, textBytes.Length);
                        return Convert.ToBase64String(bytes, 0, bytes.Length);
                    }
                }
            }
        }
        public static string Decrypt(string cipher)
        {
            using (var md5 = MD5.Create())
            {
                using (var tdes = TripleDES.Create())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateDecryptor())
                    {
                        byte[] cipherBytes = Convert.FromBase64String(cipher);
                        byte[] bytes = transform.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
                        return UTF8Encoding.UTF8.GetString(bytes);
                    }
                }
            }
        }
        private void ExportDtgvToXML()
        {
            DataGridView dtgv = control.GetDTGV();

            // Tạo một tệp XML mới
            XmlTextWriter xmlWriter = new XmlTextWriter("config1.xml", System.Text.Encoding.UTF8);
            XmlTextWriter xmlWriter2 = new XmlTextWriter("config2.xml", System.Text.Encoding.UTF8);

            xmlWriter.Formatting = Formatting.Indented;
            xmlWriter.WriteStartDocument();
            xmlWriter2.Formatting = Formatting.Indented;
            xmlWriter2.WriteStartDocument();

            // Bắt đầu phần <configuration>
            xmlWriter.WriteStartElement("configuration");
            xmlWriter2.WriteStartElement("configuration");
            // Bắt đầu phần <appSettings>
            xmlWriter.WriteStartElement("appSettings");
            xmlWriter2.WriteStartElement("appSettings");

            foreach (DataGridViewRow row in dtgv.Rows)
            {
                // Kiểm tra nếu dòng không phải dòng trống và không phải dòng header
                if (!row.IsNewRow)
                {
                    // Ghi phần tử <add> với các thuộc tính key và value
                    xmlWriter.WriteStartElement("add");
                    xmlWriter2.WriteStartElement("add");

                    int i = 0; // ô thứ 1
                    // Lặp qua từng ô trong dòng
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        string? cellValue = cell.Value?.ToString();
                        // Kiểm tra nếu ô không phải ô trống
                        if (cellValue != null)
                        {
                            // Lấy giá trị của ô
                            if (i == 0)
                            {
                                xmlWriter.WriteAttributeString("key", cellValue);
                                string encryptValue = Encrypt(cellValue);
                                xmlWriter2.WriteAttributeString("key", encryptValue);
                            }
                            if (i == 1)
                            {
                                xmlWriter.WriteAttributeString("value", cellValue);
                            }
                            if (i == 2)
                            {
                                string encryptValue = Encrypt(cellValue);
                                xmlWriter2.WriteAttributeString("value", encryptValue);
                            }
                            i++;
                        }
                    }

                    xmlWriter.WriteEndElement();
                    xmlWriter2.WriteEndElement();
                }
            }

            // Kết thúc phần <appSettings>
            xmlWriter.WriteEndElement();
            xmlWriter2.WriteEndElement();

            // Kết thúc phần <configuration>
            xmlWriter.WriteEndElement();
            xmlWriter2.WriteEndElement();

            // Kết thúc tệp XML
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
            xmlWriter2.WriteEndDocument();
            xmlWriter2.Close();

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ImportFromExcel();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void btnExportXML_Click(object sender, EventArgs e)
        {
            ExportDtgvToXML();
        }

        private void btnDecodeXml_Click(object sender, EventArgs e)
        {
            string xmlFilePath = ".\\config2.xml";
            string outputFilePath = ".\\text.txt";

            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlFilePath);

                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {

                    XmlNodeList? addNodes = xmlDoc.SelectNodes("//add");
                    if (addNodes != null)
                    {
                        foreach (XmlNode addNode in addNodes)
                        {
                            XmlAttributeCollection? attributes = addNode.Attributes;
                            if (attributes != null)
                            {
                                XmlAttribute? keyAttribute = attributes["key"];
                                
                                if (keyAttribute != null)
                                {
                                    XmlAttribute? valueAttribute = attributes["value"];
                                    string decryptedValue = "";
                                    if (valueAttribute != null)
                                    {
                                        string encryptedValue = valueAttribute.Value;
                                        decryptedValue = Decrypt(encryptedValue);
                                    }
                                    string encryptedKey = keyAttribute.Value;
                                    string decryptedKey = Decrypt(encryptedKey);
                                    
                                    writer.WriteLine("MaTrangThai: " + decryptedKey + "\t\tMoTa: " + decryptedValue);
                                }
                            }
                        }
                    } 
                }

                Console.WriteLine("Đã ghi dữ liệu vào file txt thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
