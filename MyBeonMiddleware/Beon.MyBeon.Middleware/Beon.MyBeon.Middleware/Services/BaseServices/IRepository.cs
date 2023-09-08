using Beon.MyBeon.Middleware.Models;
using Beon.MyBeon.Middleware.Models.ResultModels;

namespace Beon.MyBeon.Middleware.Services.BaseServices
{
    public interface IRepository<T> where T : class
    {
        Task<DataResult<T>> GetObject(HttpClient httpClient, Guid Oid);
        Task<DataResult<IEnumerable<T>>> GetObjects(HttpClient httpClient,string query = null!);
        Task<DataResult<T>> InsertObject(HttpClient httpClient, T item);
        Task<DataResult<T>> UpdateObject(HttpClient httpClient, T item);
        Task<DataResult<T>> DeleteObject(HttpClient httpClient, T item);

    }
}
