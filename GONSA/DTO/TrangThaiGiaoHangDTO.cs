using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TrangThaiGiaoHangDTO
    {
        private string maTrangThaiGiaoHang;
        private string tenTrangThai;
        private string moTa;
        public TrangThaiGiaoHangDTO(string maTrangThaiGiaoHang, string tenTrangThai, string moTa)
        {
            this.maTrangThaiGiaoHang=maTrangThaiGiaoHang;
            this.tenTrangThai=tenTrangThai;
            this.moTa=moTa;
        }

        public string MaTrangThaiGiaoHang { get => maTrangThaiGiaoHang; set => maTrangThaiGiaoHang = value; }
        public string TenTrangThai { get => tenTrangThai; set => tenTrangThai = value; }
        public string MoTa { get => moTa; set => moTa = value; }
    }
}
