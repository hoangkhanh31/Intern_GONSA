using API.Interface;
using API.Models;

namespace API.Repository
{
    public class CbnvGonsaRepository : ICbnvGonsaRepository
    {
        private readonly GonsaContext _context = new();
        public CbnvGonsaRepository(GonsaContext context)
        {
            _context = context;
        }
        public void AddCbnvGonsa(CbnvGonsa cbnv)
        {
            _context.Add(cbnv);
            _context.SaveChanges();
        }

        public bool CheckCbnvGonsa(string id)
        {
            var data = _context.CbnvGonsas.SingleOrDefault(item => item.MaNhanVien.Equals(id));
            if (data != null)
            {
                return true;
            }
            return false;
        }

        public void DeleteCbnvGonsaByID(string id)
        {
            var data = _context.CbnvGonsas.SingleOrDefault(item => item.MaNhanVien.Equals(id));
            if (data != null)
            {
                _context.Remove(data);
                _context.SaveChanges();
            }
        }

        public List<CbnvGonsa>? GetAll()
        {
            var data = _context.CbnvGonsas.ToList();
            if (data != null)
            {
                return data;
            }
            return null;
        }

        public CbnvGonsa? GetCbnvGonsaByID(string id)
        {
            var data = _context.CbnvGonsas.SingleOrDefault(item => item.MaNhanVien.Equals(id));
            if (data != null)
            {
                return data;
            }
            return null;
        }

        public void UpdateCbnvGonsa(CbnvGonsa cbnv)
        {
            var data = _context.CbnvGonsas.SingleOrDefault(item => item.MaNhanVien.Equals(cbnv.MaNhanVien));
            if (data != null)
            {
                data.TenNhanVien = cbnv.TenNhanVien;
                _context.SaveChanges();
            }
        }
    }
}
