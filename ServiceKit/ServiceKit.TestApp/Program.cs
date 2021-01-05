using Refit;
using ServiceKit.Sdk;
using System;
using System.Threading.Tasks;

namespace ServiceKit.TestApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var hostUrl = "https://localhost:5001/";
            var api = RestService.For<IServiceApi>(hostUrl);
            var result = await api.GetService();
            Console.WriteLine(result.Content.ServiceId);
            Console.WriteLine(result.Content.ServiceName);
            Console.ReadLine();
        }
    }
}
