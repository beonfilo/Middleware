using Beon.MyBeon.Middleware.Services;
using System.Text;
using System.Text.Json;

namespace Beon.MyBeon.Middleware.DataStores
{
	public class PasswordDataStore : IPasswordService
	{
		private string PostUrl = "/api/Password";
		public async Task<bool> ComparePassword(HttpClient httpClient, Guid Oid, string password)
		{
			var response = await httpClient.PostAsync(requestUri: $"{PostUrl}/ComparePassword?Oid={Oid.ToString()}", content: new StringContent(JsonSerializer.Serialize(password), encoding: Encoding.UTF8, mediaType: "application/json"));

			if (!response.IsSuccessStatusCode)
			{
				throw new Exception("Error");
			}
			else
			{
				return true;
			}

		}
		public async Task SetPassword(HttpClient httpClient, Guid Oid, string password)
		{
			var response = await httpClient.PostAsync(requestUri: $"{PostUrl}/SetPassword?Oid={Oid.ToString()}", content: new StringContent(JsonSerializer.Serialize(password), encoding: Encoding.UTF8, mediaType: "application/json"));

			if (!response.IsSuccessStatusCode)
			{

				throw new Exception("Error");

			}
		}
	}
}
