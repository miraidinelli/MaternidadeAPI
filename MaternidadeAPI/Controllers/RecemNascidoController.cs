using MaternidadeAPI.Model;
using MaternidadeAPI.Service;

using Microsoft.AspNetCore.Mvc;

namespace MaternidadeAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RecemNascidoController : ControllerBase
	{
		private readonly IRecemNascidoService _recemNascidoService;
		public RecemNascidoController(IRecemNascidoService recemNascidoService)
		{
			_recemNascidoService = recemNascidoService;
		}
		[HttpGet]
		public async Task<ActionResult<List<RecemNascidoModel>>> GetAllRecemNascidos()
		{
			var request = await _recemNascidoService.GetAllRecemNascidos();

			if (request == null)
			{
				return NotFound("Recem Nascido Não Encontrado");
			}
			return Ok(request);
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetRecemNascido(int id)
		{
			var request = await _recemNascidoService.GetRecemNascidoById(id);

			if (request == null)
			{
				return NotFound("Recem Nascido Não Encontrado");
			}
			return Ok(request);
		}

		[HttpGet("cesaria/")]
		public async Task<IActionResult> GetAllCesariaRecemNascido()
		{
			var request = await _recemNascidoService.GetAllCesariaRecemNascido();

			if (request == null)
			{
				return NotFound("Recem Nascido Não Encontrado");
			}
			return Ok(request);
		}

		[HttpGet("byMomId/{id}")]
		public async Task<IActionResult> GetRecemNascidoByMom(int id)
		{
			var request = await _recemNascidoService.GetRecemNascidoByMom(id);

			if (request == null)
			{
				return NotFound("Recem Nascido Não Encontrado");
			}
			return Ok(request);
		}

		[HttpGet("byMomName/{name}")]
		public async Task<IActionResult> GetRecemNascidoByMom(string name)
		{
			var request = await _recemNascidoService.GetRecemNascidoByMom(name);

			if (request == null)
			{
				return NotFound("Recem Nascido Não Encontrado");
			}
			return Ok(request);
		}

		[HttpGet("byWeight/{weight}")]
		public async Task<IActionResult> GetRecemNascidoByWeight(double weight)
		{
			var request = await _recemNascidoService.GetRecemNascidoByWeight(weight);

			if (request == null)
			{
				return NotFound("Recem Nascido Não Encontrado");
			}
			return Ok(request);
		}

		[HttpGet("byHeight/{height}")]
		public async Task<IActionResult> GetRecemNascidoByHeight(double height)
		{
			var request = await _recemNascidoService.GetRecemNascidoByHeight(height);

			if (request == null)
			{
				return NotFound("Recem Nascido Não Encontrado");
			}
			return Ok(request);
		}

		[HttpPost]
		public async Task<IActionResult> AddRecemNascido(RecemNascidoModel recemNascido)
		{
			var request = await _recemNascidoService.AddRecemNascido(recemNascido);

			return Ok(request);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteRecemNascido(int id)
		{
			var request = await _recemNascidoService.DeleteRecemNascido(id);

			if (request == null)
			{
				return NotFound("Recem Nascido Não Encontrado");
			}
			return Ok(request);
		}

		[HttpPut]
		public async Task<IActionResult> UpdateRecemNascido(int id, RecemNascidoModel recemNascido)
		{
			var request = await _recemNascidoService.UpdateRecemNascido(id, recemNascido);

			if (request == null)
			{
				return NotFound("Recem Nascido Não Encontrado");
			}
			return Ok(request);
		}
	}
}
