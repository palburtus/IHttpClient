using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aaks.IHttpClient
{
    public interface IHttpClient
    {
        Task<object> Get<T>(string url, Dictionary<string, string>? headers = null);
    }
}
