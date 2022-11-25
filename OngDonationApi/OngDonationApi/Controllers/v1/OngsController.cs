using Microsoft.AspNetCore.Mvc;
using OngDonationApi.Models;
using OngDonationApi.Repositories.Interfaces;


namespace OngDonationApi.Controllers.v1
{
    [Route("api/ongs")]
    [ApiController]
    public class OngsController : ControllerBase
    {
        private readonly IOngsRepository _repository;

        public OngsController(IOngsRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetOngs()
        {
            var ongs = await _repository.GetOngs();            
            return Ok(ongs);
        }

        [HttpGet("cnpj/{cnpj}")]
        public async Task<IActionResult> GetOngByCnpj(string cnpj)
        {
            var ong = await _repository.GetOngByCnpj(cnpj);
            
            return Ok(ong);
        }

        [HttpGet("city/{city}")]
        public async Task<IActionResult> GetOngByCity(string city)
        {
            var ongInThisCity = await _repository.GetOngByCity(city);
           
            return Ok(ongInThisCity);
        }        

        [HttpPost]
        public async Task<IActionResult> CreateOng([FromBody] Ong ong)
        {
            _repository.CreateOng(ong);
            return CreatedAtAction(nameof(GetOngs), new { id = ong.Id }, ong);
        }      

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteOng(string id)
        {
            await _repository.DeleteOng(id);
            return NoContent();
        }
    }
}
