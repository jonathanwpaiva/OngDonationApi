using OngDonationApi.Facades.Interfaces;
using OngDonationApi.Models.Responses;
using OngDonationApi.Services.Interfaces;

namespace OngDonationApi.Facades
{
    public class CnpjFacade : ICnpjFacade
    {
        private readonly ICnpjService _cnpjService;

        public CnpjFacade(ICnpjService cnpjService)
        {
            _cnpjService = cnpjService;
        }

        public async Task<CnpjResponse> GetCnpjInfosAsync(string cnpj)
        {
            var cnpjInfos = await _cnpjService.GetCnpjInfosAsync(cnpj);
            return cnpjInfos;
        }
    }
}
