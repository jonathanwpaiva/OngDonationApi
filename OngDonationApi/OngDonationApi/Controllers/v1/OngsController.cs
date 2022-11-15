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
