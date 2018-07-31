using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp
{
    public static class Helper
    {
        public static async Task<Uri> FirstWebSocketDebuggerUrlAsync()
        {
            return await FirstWebSocketDebuggerUrlAsync(9222);
        }

        public static async Task<Uri> FirstWebSocketDebuggerUrlAsync(int port)
        {
            var url = $"http://localhost:{port}/json";

            HttpClient client = new HttpClient();
            var resp = await client.GetAsync(url);

            var arr = JArray.Parse(await resp.Content.ReadAsStringAsync());
            return new Uri(arr.First["webSocketDebuggerUrl"].ToString());
        }
    }
}
