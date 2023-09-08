using Beon.MyBeon.Middleware.Services;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text;
using Beon.MyBeon.Middleware.Models.ResultModels;
using Beon.MyBeon.Middleware.Models;
using System.Text.Json.Nodes;

namespace Beon.MyBeon.Middleware.DataStores;

public class AuthenticationDataStore : IAuthenticationService
{
    public async ValueTask<DataResult<AuthenticateModel>> Authenticate(HttpClient httpClient, string UserName, string Password)
    {
        DataResult<AuthenticateModel> result = new DataResult<AuthenticateModel>();
        var responseMessage = await httpClient.PostAsync($"/api/Authentication/Authenticate",
                 new StringContent(JsonSerializer.Serialize(new { 
                    userName = UserName, 
                    password = Password 
                 }), Encoding.UTF8, "application/json"));

        if (responseMessage.IsSuccessStatusCode)
        {
            var token = await responseMessage.Content.ReadAsStringAsync();

            if (!string.IsNullOrEmpty(token))
            {
                result.Data = new AuthenticateModel { Token = token };
                result.Message = "Success";
                result.IsSuccess = true;
            }
            else
            {
                result.IsSuccess = false;
                result.Message = token;
            }
        }
        else
        {
            result.IsSuccess = false;
            result.Message = await responseMessage.Content.ReadAsStringAsync();
        }

        return result;
    }
}
