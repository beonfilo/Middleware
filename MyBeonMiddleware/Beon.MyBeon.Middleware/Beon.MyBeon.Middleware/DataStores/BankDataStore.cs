using Beon.MyBeon.Middleware.DataStores.BaseDataStores;
using Beon.MyBeon.Middleware.Models;
using Beon.MyBeon.Middleware.Services;

namespace Beon.MyBeon.Middleware.DataStores
{
    public class BankDataStore : BaseDataStore<Bank>,IBankService
    {
    }
}
