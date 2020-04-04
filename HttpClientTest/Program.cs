using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;


namespace HttpClientTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client_id = "gWS7RFBJTwsWS5Yrva";
            


        var client = new HttpClient();
        var content = new StringContent("?client_id=gWS7RFBJTwsWS5Yrva&response_type=code");
        var response = await client.PostAsync("https://bitbucket.org/site/oauth2/access_token",content);

        Console.WriteLine(response);
        }
}
}

