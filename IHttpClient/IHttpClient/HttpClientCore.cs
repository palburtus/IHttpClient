namespace Aaks.IHttpClient
{
    public class HttpClientCore : IHttpClient
    {
        public Task<object> Get<T>(string url, Dictionary<string, string>? headers = null)
        {
            throw new NotImplementedException();
        }
    }
}