using System;
using System.Collections.Generic;

namespace DTO
{
    public partial class DonHangXuatDTO
    {
        public string MaDonHang { get; set; } = null!;
        public string? MaDonHangGonsa { get; set; }
        public string? MaKhoiTaoDonHang { get; set; }
        public DateTime? NgayKeToanDuyetCtu { get; set; }
        public string? NguoiMuaHang { get; set; }
        public string? NguoiNhanHang { get; set; }
        public string? NguoiLapPhieu { get; set; }
        public string? TenCtyXuatHdon { get; set; }
        public DateTime? NgayDatHang { get; set; }
        public DateTime? NgayNhapXuatKho { get; set; }
        public string? SoPhieuXuat { get; set; }
        public string? SoAsn { get; set; }
        public string? SoPoNguyenKien { get; set; }
        public string? ChungTuThamChieu { get; set; }
        public string? Ctkm { get; set; }
        public string? GhiChu { get; set; }
        public string? MaLoaiGhiChu { get; set; }
        public string? MaKenhBanHang { get; set; }
        public string? MaLoaiDonHang { get; set; }
        public string? MaHinhThuc { get; set; }
        public string? MaKhachHang { get; set; }
        public string? MaTrangThaiGiaoHang { get; set; }
        public string? MaTrangThaiDonHang { get; set; }
        public string? MaHopDong { get; set; }
        public string? TenCtyPhanPhoi { get; set; }
        public string? MaPhieu { get; set; }

    }
}
