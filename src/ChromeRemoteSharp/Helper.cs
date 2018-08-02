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
        public static async Task<bool> CheckWebSocketAsync(int port = 9222)
        {
            var url = $"http://localhost:{port}/json";
            HttpClient client = new HttpClient();
            try
            {
                var resp = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);
                return true;
            }
            catch (HttpRequestException ex) { }

            return false;
        }

        public static async Task<Uri> FirstWebSocketDebuggerUrlAsync(int port = 9222)
        {
            var url = $"http://localhost:{port}/json";

            HttpClient client = new HttpClient();
            var resp = await client.GetAsync(url);

            var arr = JArray.Parse(await resp.Content.ReadAsStringAsync());
            return new Uri(arr.First["webSocketDebuggerUrl"].ToString());
        }

        public static void StartChromeHeadless(string url = null, string workingDirectory = null)
        {
            var settings = new CliWrap.Models.CliSettings();
            if (!string.IsNullOrEmpty(workingDirectory))
                settings.WorkingDirectory = workingDirectory;

            // "C:\Program Files (x86)\Google\Chrome\Application\"chrome --headless --enable-automation --enable-logging --disable-gpu --remote-debugging-port=9222 
            using (var cli = new CliWrap.Cli(@"C:\Program Files (x86)\Google\Chrome\Application\chrome", settings))
            {
                cli.ExecuteAndForget($"--headless --incognito --disable-extensions --safe-plugins --disable-translate --enable-automation --disable-gpu --remote-debugging-port=9222 {url}");
            }
        }

        public static void StartChromeDevTools(int port = 9222)
        {
            using (var cli = new CliWrap.Cli(@"C:\Program Files (x86)\Google\Chrome\Application\chrome"))
            {
                cli.ExecuteAndForget($"--disable-gpu http://localhost:{port}");
            }
        }

        public static void KillAllChromeInstances()
        {
            // taskkill /F /IM chrome.exe /T
            using (var cli = new CliWrap.Cli("taskkill"))
            {
                var ret = cli.Execute("/F /IM chrome.exe /T");

                if (ret.ExitCode != 128 && ret.ExitCode != 0)
                    throw new InvalidProgramException(ret.StandardError);
            }
        }
    }
}
