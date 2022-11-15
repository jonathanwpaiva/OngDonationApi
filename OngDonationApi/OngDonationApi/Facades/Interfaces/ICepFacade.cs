using OngDonationApi.Models.Responses;

namespace OngDonationApi.Facades.Interfaces
{
    public interface ICepFacade
    {
        public Task<CepResponse> GetCepInfosAsync(string cep);
    }
}
