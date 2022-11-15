using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OngDonationApi.Facades.Interfaces;

namespace OngDonationApi.Controllers.v1
{
    [Route("api/cnpj")]
    [ApiController]
    public class CnpjController : ControllerBase
    {
        private readonly ICnpjFacade _cnpjfacade;

        public CnpjController(ICnpjFacade cnpjfacade)
        {
            _cnpjfacade = cnpjfacade;
        }

        [HttpGet]
        public async Task<IActionResult> GetCnpjInfosAsync(string cnpj)
        {
            var cnpjInfos = await _cnpjfacade.GetCnpjInfosAsync(cnpj);

            if (cnpjInfos is null)
            {
                return NotFound();
            }

            return Ok(cnpjInfos);
        }
    }
}
