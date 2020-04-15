using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Pathoschild.Http.Client;
using System.Net;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Collections.Specialized;
using System.ComponentModel;
using HttpClient_ConsoleApp;
using System.Security.Cryptography.X509Certificates;
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

        public static async Task<JObject> PostRequestAsync(String uri, String parameters)
        {
            {
                //using (var httpClient = new HttpClient())
                //{
                //    using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://api.bitbucket.org/2.0/repositories/WildWoz/test-repo/src"))
                //    {
                //        var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes("WildWoz:F4vTWxGmZTgQDkTYgk6m"));
                //        request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

                //        var multipartContent = new MultipartFormDataContent();
                //        multipartContent.Add(new ByteArrayContent(File.ReadAllBytes("C:/Users/adam.wozniak/Desktop/NewFolder/test.txt")), "/test15.txt", Path.GetFileName("C:/Users/adam.wozniak/Desktop/NewFolder/test.txt"));
                //        request.Content = multipartContent;

                //        var response = await httpClient.SendAsync(request);
                //    }
                //}


                var username = "WildWoz";
                var password = "TXtaL6Z2ZPRW7cv2g8mB";
                var plainText_usernamePassword = System.Text.Encoding.UTF8.GetBytes(username + ":" + password);
                var base64encoded_usernamePassword = System.Convert.ToBase64String(plainText_usernamePassword);


                var defaultHttpClient = new HttpClient();
                defaultHttpClient.DefaultRequestHeaders
                    .Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", base64encoded_usernamePassword);

                IClient client = new FluentClient("https://api.bitbucket.org/2.0/", defaultHttpClient);
                var messages = new JObject();

                var multipartContent = new MultipartFormDataContent();
                multipartContent.Add(new ByteArrayContent(File.ReadAllBytes("C:/Users/adam.wozniak/Desktop/NewFolder/TestDoc.docx")), "/a-tashFile-docx.docx", Path.GetFileName("C:/Users/adam.wozniak/Desktop/NewFolder/TestDoc.docx"));
                multipartContent.Add(new StringContent("comitting Tash first docx file."), "message");

                var url = "repositories/WildWoz/test-repo2/src";
                var responseRaw = await client
                            .PostAsync(url)
                            .WithBody(multipartContent)
                            .AsString();
                var response = new JObject();
                if (responseRaw == "")
                {
                    response = JObject.Parse("{\"response\":\"Commit successful\"}");
                }
                else
                {
                    response = JObject.Parse(responseRaw);
                }
                Console.WriteLine(responseRaw);

                return response;

                


            }
        }
    }
}

