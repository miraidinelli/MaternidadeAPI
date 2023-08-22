using MaternidadeAPI.Model;

namespace MaternidadeAPI.Service
{
    public interface IMaeService
    {
        public Task<MaeModel> GetMaeById(int id);
        public Task<List<MaeModel>?> GetAllMaes();
        public Task<MaeModel> CadMae(MaeModel mae);
        public Task<List<MaeModel>> UpdateMae(MaeModel request, int id);
    }
}
