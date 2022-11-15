using OngDonationApi.Facades.Interfaces;
using OngDonationApi.Models.Responses;
using OngDonationApi.Services.Interfaces;

namespace OngDonationApi.Facades
{
    public class CepFacade : ICepFacade
    {
        private readonly ICepService _cepService;

        public CepFacade(ICepService cepService)
        {
            _cepService = cepService;
        }

        public async Task<CepResponse> GetCepInfosAsync(string cep)
        {
            var cepInfos = await _cepService.GetCepInfosAsync(cep);
            return cepInfos;
        }
    }
}
