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

        }
}



}

        // var client = new HttpClient();
        // var request = new HttpRequestMessage(new HttpMethod("POST"), "https://bitbucket.org/site/oauth2/access_token");
        // var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes("gWS7RFBJTwsWS5Yrva:ydEdAPe6a7LAywzaWdkCxd9Qav7LDCmx"));
        // request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}"); 

        // var contentList = new List<string>();
        // contentList.Add("grant_type=authorization_code");
        // contentList.Add("code={code}");
        // request.Content = new StringContent(string.Join("&", contentList));
        // request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded"); 

        // var response = await client.SendAsync(request);

        // Console.WriteLine(response);

