using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ValidateSecretScanning
{
    public class HttpClientSample
    {
        public async Task<HttpStatusCode> Get()
        {
            using (var client = new HttpClient())
            {
                var token = "RfeyoeHI+gK5JoqQ/6+kZn46DIA//wUxNDmJNeEoCbE=";
                client.DefaultRequestHeaders.Add("x-token", token);
                var result = await client.GetAsync("https://httpstat.us/200");
                return result.StatusCode;
            }
        }
    }
}