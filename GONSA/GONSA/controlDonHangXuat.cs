using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GONSA
{
    public partial class controlDonHangXuat : UserControl
    {
        public controlDonHangXuat()
        {
            InitializeComponent();
        }

        #region Methods
        public void ShowData(DonHangXuatDTO donHangXuatDTO)
        {
            txtChungTuThamChieu.Text = donHangXuatDTO.ChungTuThamChieu;
            txtCTKM.Text = donHangXuatDTO.Ctkm;
            txtGhiChu.Text = donHangXuatDTO.GhiChu;
            txtMaDonHang.Text = donHangXuatDTO.MaDonHang;
            txtMaDonHangGonsa.Text = donHangXuatDTO.MaDonHangGonsa;
            txtMaHinhThuc.Text = donHangXuatDTO.MaHinhThuc;
            txtMaHopDong.Text = donHangXuatDTO.MaHopDong;
            txtMaKenhBanHang.Text = donHangXuatDTO.MaKenhBanHang;
            txtMaKhachHang.Text = donHangXuatDTO.MaKhachHang;
            txtMaKhoiTaoDonHang.Text = donHangXuatDTO.MaKhoiTaoDonHang;
            txtMaLoaiDonHang.Text = donHangXuatDTO.MaLoaiDonHang;
            txtMaLoaiGhiChu.Text = donHangXuatDTO.MaLoaiGhiChu;
            txtMaPhieu.Text = donHangXuatDTO.MaPhieu;
            txtMaTrangThaiDonHang.Text = donHangXuatDTO.MaTrangThaiDonHang;
            txtMaTrangThaiGiaoHang.Text = donHangXuatDTO.MaTrangThaiGiaoHang;
            txtNguoiLapPhieu.Text = donHangXuatDTO.NguoiLapPhieu;
            txtNguoiMuaHang.Text = donHangXuatDTO.NguoiMuaHang;
            txtNguoiNhanHang.Text = donHangXuatDTO.NguoiNhanHang;
            txtSoASN.Text = donHangXuatDTO.SoAsn;
            txtSoPhieuXuat.Text = donHangXuatDTO.SoPhieuXuat;
            txtSoPONguyenKien.Text = donHangXuatDTO.SoPoNguyenKien;
            txtTenCongTyPhanPhoi.Text = donHangXuatDTO.TenCtyPhanPhoi;
            txtTenCongTyXuatHoaDon.Text = donHangXuatDTO.TenCtyXuatHdon;
            if (donHangXuatDTO.NgayDatHang.HasValue)
            {
                dtpkNgayDatHang.Value = (DateTime)donHangXuatDTO.NgayDatHang;
            }
            if (donHangXuatDTO.NgayKeToanDuyetCtu.HasValue)
            {
                dtpkNgayKeToanDuyetCTU.Value = (DateTime)donHangXuatDTO.NgayKeToanDuyetCtu;
            }
            if (donHangXuatDTO.NgayNhapXuatKho.HasValue)
            {
                dtpkNgayNhapXuatKho.Value = (DateTime)donHangXuatDTO.NgayNhapXuatKho;
            }            
        }
        public void EnableEdit(bool type)
        {
            if (type)
            {
                txtChungTuThamChieu.Enabled = type;
                txtCTKM.Enabled = type;
                txtGhiChu.Enabled = type;
                txtMaDonHang.Enabled = type;
                txtMaDonHangGonsa.Enabled = type;
                txtMaHinhThuc.Enabled = type;
                txtMaHopDong.Enabled = type;
                txtMaKenhBanHang.Enabled = type;
                txtMaKhachHang.Enabled = type;
                txtMaKhoiTaoDonHang.Enabled = type;
                txtMaLoaiDonHang.Enabled = type;
                txtMaLoaiGhiChu.Enabled = type;
                txtMaPhieu.Enabled = type;
                txtMaTrangThaiDonHang.Enabled = type;
                txtMaTrangThaiGiaoHang.Enabled = type;
                txtNguoiLapPhieu.Enabled = type;
                txtNguoiMuaHang.Enabled = type;
                txtNguoiNhanHang.Enabled = type;
                txtSoASN.Enabled = type;
                txtSoPhieuXuat.Enabled = type;
                txtSoPONguyenKien.Enabled = type;
                txtTenCongTyPhanPhoi.Enabled = type;
                txtTenCongTyXuatHoaDon.Enabled = type;
                dtpkNgayDatHang.Enabled = type;
                dtpkNgayKeToanDuyetCTU.Enabled = type;
                dtpkNgayNhapXuatKho.Enabled = type;
            }
            else
            {
                txtChungTuThamChieu.Enabled = type;
                txtCTKM.Enabled = type;
                txtGhiChu.Enabled = type;
                txtMaDonHang.Enabled = type;
                txtMaDonHangGonsa.Enabled = type;
                txtMaHinhThuc.Enabled = type;
                txtMaHopDong.Enabled = type;
                txtMaKenhBanHang.Enabled = type;
                txtMaKhachHang.Enabled = type;
                txtMaKhoiTaoDonHang.Enabled = type;
                txtMaLoaiDonHang.Enabled = type;
                txtMaLoaiGhiChu.Enabled = type;
                txtMaPhieu.Enabled = type;
                txtMaTrangThaiDonHang.Enabled = type;
                txtMaTrangThaiGiaoHang.Enabled = type;
                txtNguoiLapPhieu.Enabled = type;
                txtNguoiMuaHang.Enabled = type;
                txtNguoiNhanHang.Enabled = type;
                txtSoASN.Enabled = type;
                txtSoPhieuXuat.Enabled = type;
                txtSoPONguyenKien.Enabled = type;
                txtTenCongTyPhanPhoi.Enabled = type;
                txtTenCongTyXuatHoaDon.Enabled = type;
                dtpkNgayDatHang.Enabled = type;
                dtpkNgayKeToanDuyetCTU.Enabled = type;
                dtpkNgayNhapXuatKho.Enabled = type;
            }
        }
        public void ClearData()
        {
            txtChungTuThamChieu.Text = "";
            txtCTKM.Text = "";
            txtGhiChu.Text = "";
            txtMaDonHang.Text = "";
            txtMaDonHangGonsa.Text = "";
            txtMaHinhThuc.Text = "";
            txtMaHopDong.Text = "";
            txtMaKenhBanHang.Text = "";
            txtMaKhachHang.Text = "";
            txtMaKhoiTaoDonHang.Text = "";
            txtMaLoaiDonHang.Text = "";
            txtMaLoaiGhiChu.Text = "";
            txtMaPhieu.Text = "";
            txtMaTrangThaiDonHang.Text = "";
            txtMaTrangThaiGiaoHang.Text = "";
            txtNguoiLapPhieu.Text = "";
            txtNguoiMuaHang.Text = "";
            txtNguoiNhanHang.Text = "";
            txtSoASN.Text = "";
            txtSoPhieuXuat.Text = "";
            txtSoPONguyenKien.Text = "";
            txtTenCongTyPhanPhoi.Text = "";
            txtTenCongTyXuatHoaDon.Text = "";
            dtpkNgayDatHang.Value = DateTime.Now;
            dtpkNgayKeToanDuyetCTU.Value = DateTime.Now;
            dtpkNgayNhapXuatKho.Value = DateTime.Now;
        }
        #endregion

    }
}
