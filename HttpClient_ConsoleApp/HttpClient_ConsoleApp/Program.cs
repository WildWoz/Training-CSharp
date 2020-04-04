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
        static HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            await PostRequestAsync("https://bitbucket.org/site/oauth2/authorize?client_id=gWS7RFBJTwsWS5Yrva&response_type=code", "");
            Console.WriteLine("Hello");
        }

        public static async Task<string> PostRequestAsync(String uri, String parameters)
        {
            Console.WriteLine("Testing1");
            var client_id = "gWS7RFBJTwsWS5Yrva";
            //parameters = "";
            //uri = "https://bitbucket.org/site/oauth2/access_token";
            var authUrl = "https://bitbucket.org/site/oauth2/authorize?client_id=" + client_id + "&response_type=code";
            System.Diagnostics.Process.Start(authUrl);
            var response = await client.PostAsync(uri, new StringContent(parameters));
            var content = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Testing2: " + content);


            return content;
        }
    }
}

