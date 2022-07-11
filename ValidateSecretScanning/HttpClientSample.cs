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
                var token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c";
                client.DefaultRequestHeaders.Add("x-token", token);
                var result = await client.GetAsync("https://httpstat.us/200");
                return result.StatusCode;
            }
        }
    }
}