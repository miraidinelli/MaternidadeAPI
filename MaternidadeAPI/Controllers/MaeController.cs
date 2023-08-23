using MaternidadeAPI.Model;
using MaternidadeAPI.Service;

using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace MaternidadeAPI.Controllers
{
	public class MaeController : Controller
	{
		private readonly IMaeService _maeService;
		public MaeController(IMaeService maeService)
		{
			_maeService = maeService;
		}
		[HttpGet]
		public async Task<ActionResult<List<MaeModel>>> GetAllMaes()
		{
			var mae = await _maeService.GetAllMaes();
			if (mae == null)
			{
				NotFound("A Pesquisa não retornou nenhum resultado");
			}
			return Ok(mae);
		}
		[HttpGet("byEstado/{estadocivil}")]
		public async Task<ActionResult<List<MaeModel>>> GetMaeByEstadoCivil(string estado)
		{
			var mae = await _maeService.GetMaeByEstadoCivil(estado);
			if (mae == null)
			{
				NotFound("A Pesquisa não retornou nenhum resultado");
			}
			return Ok(mae);
		}
        [HttpGet("id")]
		public async Task<ActionResult<MaeModel>> GetMaeById(int id)
		{
			var mae = await _maeService.GetMaeById(id);
			if (mae == null)
			{
				return NotFound("Mãe não encontrada");
			}
			return Ok(mae);
		}
		[HttpPatch("maes/{id}")]
		public async Task<ActionResult<MaeModel>> UpdateHistoricoMedico(string request, int id)
		{
			var mae = await _maeService.UpdateHistoricoMedico(request, id);
			if (mae == null)
			{
				return NotFound("Mãe não encontrada");
			}
			return Ok(mae);
		}
		[HttpPut]
		public async Task<ActionResult<MaeModel>> AddMae(MaeModel maerequest)
		{
			var mae = await _maeService.AddMae(maerequest);
			return Ok(mae);
		}
		[HttpPost]
		public async Task<ActionResult<MaeModel>> UpdateMae(MaeModel request, int id)
		{
			var mae = await _maeService.UpdateMae(request, id);

			if (request == null)
			{
				return NotFound("Mãe Não Encontrada");
			}
			return Ok(request);
		}

	}
}
