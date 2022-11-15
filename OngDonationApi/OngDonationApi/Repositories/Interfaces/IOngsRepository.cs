using Microsoft.Extensions.Options;
using OngDonationApi.Models;
using OngDonationApi.Models.UI;

namespace OngDonationApi.Repositories.Interfaces
{
    public interface IOngsRepository
    {
        //public Ong GetOngById(string id);
        public Task<IEnumerable<Ong>> GetOngs();
        public Task CreateOng(Ong ong);
        //public Task UpdateOng(Ong ong);
        public Task DeleteOng(string id);
    }
}