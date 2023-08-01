using API.Models;

namespace API.Interface
{
    public interface ICbnvGonsaRepository
    {
        List<CbnvGonsa>? GetAll();
        CbnvGonsa? GetCbnvGonsaByID(string id);
        void AddCbnvGonsa(CbnvGonsa cbnv);
        void UpdateCbnvGonsa(CbnvGonsa cbnv);
        void DeleteCbnvGonsaByID(string id);
        bool CheckCbnvGonsa(string id);
    }
}
