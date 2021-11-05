using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Contracts
{
    public interface IHttpRepository<T> where T : class
    {
        Task<T> Get(string url, int id);
        Task<List<T>> Search(string url, string country);
        Task<T> GetDetails(string url, int id);
        Task<List<T>> GetAll(string url);
        Task Create(string url, T obj);
        Task Update(string url, T obj, int id);
        Task Delete(string url, int id);
    }
}
