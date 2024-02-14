using System.Net.Http;
using System.Security.AccessControl;

namespace _055_ConstReadOnly
{
    internal class Program
    {
        class ApiClient
        {
            private readonly string baseUrl = "https://our-api-dev.com";
            private const string gerUserEndpoint = "/api/users";
            private HttpClient httpClient = new HttpClient();
            private int defaultPort = 80;

            public ApiClient(string baseUrl)
            {
                this.baseUrl = baseUrl;
                // gerUserEndpoint = "Nowy Napis";  const nie można zmienić.
                this.httpClient= new HttpClient();
            }

        }

        static void Main(string[] args)
        {
            ApiClient apiClient = new ApiClient("adresTejStrony");
            Console.WriteLine("Hello, World!");
        }
    }
}
