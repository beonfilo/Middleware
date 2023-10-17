using Beon.MyBeon.Middleware.Models;
using Beon.MyBeon.Middleware.Models.ResultModels;

namespace Beon.MyBeon.Middleware.Services.BaseServices
{
    public interface IRepository<T> where T : class
    {
        Task<DataResult<T>> GetObject(HttpClient httpClient, Guid Oid, string query = null!);
        Task<DataResult<IEnumerable<T>>> GetObjects(HttpClient httpClient,string query = null!);
        Task<DataResult<T>> InsertObject(HttpClient httpClient, object item);
        Task<DataResult<T>> PutObject(HttpClient httpClient, T item,Guid oid);
        Task<DataResult<T>> PatchObject(HttpClient httpClient, object item, Guid oid);
        Task<DataResult<T>> DeleteObject(HttpClient httpClient, T item);

    }
}
