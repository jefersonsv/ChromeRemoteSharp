using System;
using System.Threading;
using System.Threading.Tasks;
using ChromeRemoteSharp;

namespace HelloChrome
{
    class Program
    {
        static WebDriver driver = null;

        static void Main(string[] args)
        {
            var url = Helper.FirstWebSocketDebuggerUrlAsync().Result;
            driver = new WebDriver(url);

            Run();

            System.Threading.Thread.Sleep(Timeout.Infinite);
            driver.CloseConnection();
        }

        static async Task Run()
        {
            //var navi = await driver.NavigateAsync(new Uri("https://www.globo.com"));
            //var frameId = navi["result"]["frameId"].ToString();
            //Console.WriteLine(frameId);
            //Console.WriteLine(navi);

            //var p = await driver.CaptureScreenshotAsync();
            //Console.WriteLine(p);

            //Console.WriteLine(await driver.GetVersionAsync());
            //Console.WriteLine(await driver.GetBrowserCommandLineAsync());
            //Console.WriteLine(await driver.GetCookiesAsync());

            var doc = await driver.Dom.GetDocumentAsync();
            var nodeid = doc["result"]["root"]["nodeId"].ToString();
            Console.WriteLine(doc);
            //Console.WriteLine(await driver.Dom.GetOuterHtmlAsync());
        }
    }
}
