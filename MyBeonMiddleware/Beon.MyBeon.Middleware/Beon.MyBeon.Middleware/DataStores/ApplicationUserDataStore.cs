using Beon.MyBeon.Middleware.DataStores.BaseDataStores;
using Beon.MyBeon.Middleware.Models;
using Beon.MyBeon.Middleware.Models.ResultModels;
using Beon.MyBeon.Middleware.Services;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Beon.MyBeon.Middleware.DataStores;

public class ApplicationUserDataStore : BaseDataStore<ApplicationUser>, IApplicationUserService
{
}
