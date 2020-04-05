using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Pathoschild.Http.Client;
using System.Net;
//using System.Messaging;

namespace HttpClientTest
{
    class Program
    {
        static HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            // Passing this in here just as Main is the entry point and this file is more of a sandbox.
            await PostRequestAsync("", "");
        }

        public static async Task<string> PostRequestAsync(String uri, String parameters)
        {
            {
                IClient client = new FluentClient("https://api.bitbucket.org/2.0/");

                var messages = await client
                    .GetAsync("repositories")
                    .WithBasicAuthentication("WildWoz", "TXtaL6Z2ZPRW7cv2g8mB")
                    .AsRawJsonObject();

                Console.WriteLine(messages.ToString());

                return messages.ToString();


            }
        }
    }
}

