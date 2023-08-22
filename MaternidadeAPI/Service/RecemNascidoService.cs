using MaternidadeAPI.Data;
using MaternidadeAPI.Model;

using Microsoft.EntityFrameworkCore;

namespace MaternidadeAPI.Service
{
	public class RecemNascidoService : IRecemNascidoService
	{
		private readonly DataContext _dataContext;

		public RecemNascidoService(DataContext dataContext)
		{
			_dataContext = dataContext;
		}
		public async Task<List<RecemNascidoModel>?> AddRecemNascido(RecemNascidoModel rn)
		{
			_dataContext.RecemNascido.Add(rn);
			await _dataContext.SaveChangesAsync();
			return await GetAllRecemNascidos();
		}

		public async Task<List<RecemNascidoModel>?> DeleteRecemNascido(int id)
		{
			var rn = await _dataContext.RecemNascido.FindAsync(id);
			if(rn == null)
			{
				return null;
			}
			_dataContext.RecemNascido.Remove(rn);
			await _dataContext.SaveChangesAsync();
			return await GetAllRecemNascidos();
		}

		public async Task<List<RecemNascidoModel>?> GetAllCesariaRecemNascido()
		{
			var rns = await _dataContext.RecemNascido.Where<RecemNascidoModel>(rn => rn.Parto == "cesaria").ToListAsync();
			if(rns == null)
			{
				return null;
			}
			return rns;
		}

		public async Task<List<RecemNascidoModel>?> GetAllRecemNascidos()
		{
			var rns = await _dataContext.RecemNascido.ToListAsync();
			if (rns == null)
			{
				return null;
			}
			return rns;
		}

		public async Task<List<RecemNascidoModel>?> GetRecemNascidoByHeight(double height)
		{
			var rns = await _dataContext.RecemNascido.Where(rn => rn.Altura > height).ToListAsync();
			if (rns == null)
			{
				return null;
			}
			return rns;
		}

		public async Task<RecemNascidoModel?> GetRecemNascidoById(int id)
		{
			var rn = await _dataContext.RecemNascido.FindAsync(id);
			if (rn == null)
			{
				return null;
			}
			return rn;
		}

		public async Task<List<RecemNascidoModel>?> GetRecemNascidoByMom(int momId)
		{
			var rn = await _dataContext.RecemNascido.Where(rn => rn.Mae.Id == momId).ToListAsync();
			if (rn == null)
			{
				return null;
			}
			return rn;
		}

		public async Task<List<RecemNascidoModel>?> GetRecemNascidoByMom(string momFirstName)
		{
			var rn = await _dataContext.RecemNascido.Where(rn => rn.Mae.Nome == momFirstName).ToListAsync();
			if (rn == null)
			{
				return null;
			}
			return rn;
		}

		public async Task<List<RecemNascidoModel>?> GetRecemNascidoByWeight(double weight)
		{
			var rn = await _dataContext.RecemNascido.Where(rn => rn.Peso > weight).ToListAsync();
			if (rn == null)
			{
				return null;
			}
			return rn;
		}

		public async Task<List<RecemNascidoModel>?> UpdateRecemNascido(int id, RecemNascidoModel rnRequest)
		{
			var rnDb = await _dataContext.RecemNascido.FindAsync(id);
			if (rnDb == null)
			{
				return null;
			}

			rnDb.Nome = rnRequest.Nome;
			rnDb.Genero = rnRequest.Genero;
			rnDb.Parto = rnRequest.Parto;
			rnDb.Nascimento = rnRequest.Nascimento;
			rnDb.Peso = rnRequest.Peso;
			rnDb.Altura = rnRequest.Altura;
			rnDb.Condicao = rnRequest.Condicao;
			rnDb.Mae = rnRequest.Mae;

			_dataContext.Update(rnDb);
			await _dataContext.SaveChangesAsync();
			return await GetAllRecemNascidos();
		}
	}
}
