using Beon.MyBeon.Middleware.Models;
using Beon.MyBeon.Middleware.Models.ResultModels;
using Beon.MyBeon.Middleware.Services.BaseServices;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.Text;

namespace Beon.MyBeon.Middleware.DataStores.BaseDataStores
{
    public class BaseDataStore<T> : IRepository<T> where T : class
    {
        private string PostUrl = "/api/odata/" + typeof(T).Name;
        public async Task<DataResult<T>> DeleteObject(HttpClient httpClient, T item)
        {
            throw new NotImplementedException();
        }

        public async Task<DataResult<T>> GetObject(HttpClient httpClient, Guid Oid)
        {
            throw new NotImplementedException();
        }

        public async Task<DataResult<IEnumerable<T>>> GetObjects(HttpClient httpClient, string query = "")
        {
            DataResult<IEnumerable<T>> result = new DataResult<IEnumerable<T>>();

            var response = await httpClient.GetAsync($"{PostUrl}{query}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(json))
                {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    var data = JsonNode.Parse(json)["value"].Deserialize<IEnumerable<T>>();
#pragma warning restore CS8602 // Dereference of a possibly null reference.

                    result.IsSuccess = true;
                    result.Message = "Success";
                    result.Data = data;
                }
                else
                {
                    result.IsSuccess = false;
                    result.Data = null;
                    result.Message = "Empty Data";
                }
            }
            else
            {
                result.IsSuccess = false;
                result.Data = null;
                result.Message = await response.Content.ReadAsStringAsync();
            }


            return await Task.FromResult(result);
        }

        public async Task<DataResult<T>> InsertObject(HttpClient httpClient, T item)
        {
            DataResult<T> result = new DataResult<T>();

            var response = await httpClient.PostAsync(PostUrl, new StringContent(JsonSerializer.Serialize(item), encoding: Encoding.UTF8, mediaType: "application/json"));

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(json))
                {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    var data = JsonNode.Parse(json)["value"].Deserialize<T>();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                    result.IsSuccess = true;
                    result.Message = "Success";
                    result.Data = data;
                }
                else
                {
                    result.IsSuccess = false;
                    result.Data = null;
                    result.Message = "Empty Data";
                }

            }
            else
            {
                result.IsSuccess = false;
                result.Data = null;
                result.Message = await response.Content.ReadAsStringAsync();
            }

            return await Task.FromResult(result);
        }

        public async Task<DataResult<T>> UpdateObject(HttpClient httpClient, T item, Guid oid)
        {
            DataResult<T> result = new DataResult<T>();

            var response = await httpClient.PatchAsync(requestUri: $"{PostUrl}/{oid.ToString()}", content: new StringContent(JsonSerializer.Serialize(item), encoding: Encoding.UTF8, mediaType: "application/json"));

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                if (string.IsNullOrEmpty(json))
                {
                    var data = JsonNode.Parse(json)["value"].Deserialize<T>();
                    result.IsSuccess = true;
                    result.Message = "Success";
                    result.Data = data;
                }
                else
                {
                    result.IsSuccess = false;
                    result.Data = null;
                    result.Message = "Empty Data";
                }

            }
            else
            {
                result.IsSuccess = false;
                result.Data = null;
                result.Message = await response.Content.ReadAsStringAsync();
            }

            return await Task.FromResult(result);
        }
    }
}
