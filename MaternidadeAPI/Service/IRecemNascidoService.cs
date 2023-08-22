using MaternidadeAPI.Model;

namespace MaternidadeAPI.Service
{
	public interface IRecemNascidoService
	{
		Task<List<RecemNascidoModel>?> GetAllRecemNascidos();
		Task<RecemNascidoModel?> GetRecemNascidoById(int id);
		Task<List<RecemNascidoModel>?> GetAllCesariaRecemNascido();
		Task<List<RecemNascidoModel>?> GetRecemNascidoByMom(int momId);
		Task<List<RecemNascidoModel>?> GetRecemNascidoByMom(string momFirstName);
		Task<List<RecemNascidoModel>?> GetRecemNascidoByWeight(double weight);
		Task<List<RecemNascidoModel>?> GetRecemNascidoByHeight(double height);
		Task<List<RecemNascidoModel>?> AddRecemNascido(RecemNascidoModel rn);
		Task<List<RecemNascidoModel>?> UpdateRecemNascido(int id, RecemNascidoModel rn);
		Task<List<RecemNascidoModel>?> DeleteRecemNascido(int id);
	}
}
