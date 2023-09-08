using Beon.MyBeon.Middleware.Models;
using Beon.MyBeon.Middleware.Models.ResultModels;

namespace Beon.MyBeon.Middleware.Services;

public interface IAuthenticationService
{
    ValueTask<DataResult<AuthenticateModel>> Authenticate(HttpClient httpClient, string UserName, string Password);
}
