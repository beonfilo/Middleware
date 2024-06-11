using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beon.MyBeon.Middleware.Services
{
	public interface IPasswordService
	{
		public Task SetPassword(HttpClient httpClient, Guid Oid ,string password);

		public Task<bool> ComparePassword(HttpClient httpClient, Guid Oid, string password);
	}
}
