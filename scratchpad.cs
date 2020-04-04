using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

// HttpClient is intended to be instantiated once per application, rather than per-use. See Remarks.
namespace HttpClientStatus
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();

            var result = await client.GetAsync("http://webcode.me");
            Console.WriteLine(result.StatusCode);
        }
    }
}