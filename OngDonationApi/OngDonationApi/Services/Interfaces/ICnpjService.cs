using OngDonationApi.Models.Responses;
using RestEase;

namespace OngDonationApi.Services.Interfaces
{
    public interface ICnpjService
    {
        [Get("cnpj/v1/{cnpj}")]
        public Task<CnpjResponse> GetCnpjInfosAsync([Path] string cnpj);
    }
}
