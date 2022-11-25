using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OngDonationApi.Facades.Interfaces;

namespace OngDonationApi.Controllers.v1
{
    [Route("api/cep")]
    [ApiController]
    public class CepController : ControllerBase
    {
        private readonly ICepFacade _cepFacade;

        public CepController(ICepFacade cepFacade)
        {
            _cepFacade = cepFacade;
        }


        [HttpGet]
        public async Task<IActionResult> GetCepInfosAsync(string cep)
        {
            var cepInfos = await _cepFacade.GetCepInfosAsync(cep);

            if (cepInfos is null)
            {
                return NotFound();
            }

            return Ok(cepInfos);
        }
    }
}
