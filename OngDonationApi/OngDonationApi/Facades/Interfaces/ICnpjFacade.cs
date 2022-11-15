using OngDonationApi.Models.Responses;


namespace OngDonationApi.Facades.Interfaces
{
    public interface ICnpjFacade
    {
        public Task<CnpjResponse> GetCnpjInfosAsync(string cnpj);
    }
}
