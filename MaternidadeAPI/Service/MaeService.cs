using MaternidadeAPI.Data;
using MaternidadeAPI.Model;

using Microsoft.EntityFrameworkCore;

namespace MaternidadeAPI.Service
{
	public class MaeService : IMaeService
	{
		private readonly DataContext _dataContext;
		public MaeService(DataContext dataContext)
		{
			_dataContext = dataContext;
		}
		public async Task<MaeModel> AddMae(MaeModel mae)
		{
			_dataContext.Mae.Add(mae);
			await _dataContext.SaveChangesAsync();
			return mae;
		}


		public async Task<List<MaeModel>?> GetAllMaes()
		{
			var mae = await _dataContext.Mae.ToListAsync();
			return mae;
		}

		public async Task<MaeModel?> GetMaeById(int id)
		{
			var mae = await _dataContext.Mae.FindAsync(id);
			if (mae == null)
			{
				return null;
			}
			return mae;
		}

		public async Task<List<MaeModel>?> UpdateHistoricoMedico(string request, int id)
		{
			var maeDb = await _dataContext.Mae.FindAsync(id);
			if (maeDb == null)
			{
				return null;
			}
			maeDb.Historico = request;
			await _dataContext.SaveChangesAsync();
			return await GetAllMaes();
		}

		public async Task<List<MaeModel>?> UpdateMae(MaeModel request, int id)
		{
			var maeDb = await _dataContext.Mae.FindAsync(id);
			if (maeDb == null)
			{
				return null;
			}
			maeDb.Nome = request.Nome;
			maeDb.Id = request.Id;
			maeDb.Sobrenome = request.Sobrenome;
			maeDb.Fone = request.Fone;
			maeDb.Etnia = request.Etnia;
			maeDb.Profissao = request.Profissao;
			maeDb.RG = request.RG;
			maeDb.CPF = request.CPF;
			maeDb.EstadoCivil = request.EstadoCivil;
			maeDb.Nascimento = request.Nascimento;
			maeDb.Endereco = request.Endereco;
			maeDb.EstadoCivil = request.EstadoCivil;
			maeDb.Historico = request.Historico;
			await _dataContext.SaveChangesAsync();
			return await GetAllMaes();
		}
	}
}
