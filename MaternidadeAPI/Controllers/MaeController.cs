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

        [HttpGet("id")]
        public async Task<ActionResult<MaeModel>> GetMaeById(int id)
        {
            var mae = await _maeService.GetMaeById(id);
            if(mae == null)
            {
                return NotFound("Mae não encontrada");
            }
            return Ok(mae);
        }
        [HttpPut]
        public async Task<ActionResult<MaeModel>> CadMae(MaeModel maerequest)
        {
            var mae = await _maeService.CadMae(maerequest);
            return Ok(mae);
        }
        [HttpPost]
        public async Task<ActionResult<MaeModel>> UpdateMae(MaeModel request, int id)
        {
            var mae = await _maeService.UpdateMae(request, id);

            if (request == null)
            {
                return NotFound("Mae Não Encontrada");
            }
            return Ok(request);
        }

    }
}
