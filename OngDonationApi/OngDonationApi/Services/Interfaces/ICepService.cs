using OngDonationApi.Models.Responses;
using RestEase;

namespace OngDonationApi.Services.Interfaces
{
    public interface ICepService
    {

        [Get("cep/v2/{cep}")]
        public Task<CepResponse> GetCepInfosAsync([Path] string cep);
    }
}

