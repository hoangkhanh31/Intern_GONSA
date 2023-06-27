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
        public List<TrangThaiGiaoHangDTO> GetList()
        {
            return trangThaiGiaoHangDAO.GetList();
        }
    }
}
