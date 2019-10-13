using System.Net.Http;
using Refit;
namespace MobileClient.Shared.Services
{
    public class ApiFactory<T> : IApiFactory<T> where T : class
    {
        public T CreateConnection(string host)
        {
            var httpClient = new HttpClient { BaseAddress = new System.Uri(host) };
            return RestService.For<T>(host);
        }
    }

    public interface IApiFactory<out T>
    {
        T CreateConnection(string host);
    }
}
