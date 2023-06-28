using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class TrangThaiGiaoHangBUS
    {
        private TrangThaiGiaoHangDAO trangThaiGiaoHangDAO = new TrangThaiGiaoHangDAO();
        private List<TrangThaiGiaoHangDTO>? list;
        public List<TrangThaiGiaoHangDTO> GetList()
        {
            list = trangThaiGiaoHangDAO.GetList();
            if (list == null)
            {
                list = new List<TrangThaiGiaoHangDTO>();
            }
            return list;
        }
    }
}
