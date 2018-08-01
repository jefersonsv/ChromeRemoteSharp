using System;
using System.Threading;
using System.Threading.Tasks;
using ChromeRemoteSharp;

namespace HelloChrome
{
    class Program
    {
        static LowLevelDriver driver = null;

        static void Main(string[] args)
        {
            Helper.KillAllChromeInstances();
            Helper.StartChromeHeadless("");
            Helper.StartChromeDevTools();

            var url = Helper.FirstWebSocketDebuggerUrlAsync().Result;
            driver = new LowLevelDriver(url);

            Run();

            Console.ReadKey();
            driver.CloseConnection();

            //System.Threading.Thread.Sleep(Timeout.Infinite);
        }

        static async Task Run()
        {
            // navigate
            var naviJson = await driver.Page.NavigateAsync(new Uri("https://www.globo.com"));
            var frameId = naviJson["result"]["frameId"].ToString();
            
            // screenshot
            var screenShotJson = await driver.Page.CaptureScreenshotAsync();

            // get version
            Console.WriteLine(await driver.Browser.GetVersionAsync());

            // get browser command line
            Console.WriteLine(await driver.Browser.GetBrowserCommandLineAsync());

            // page cookies
            Console.WriteLine(await driver.Page.GetCookiesAsync());

            // get document
            var docJson = await driver.Dom.GetDocumentAsync();
            var nodeId = docJson["result"]["root"]["nodeId"].ToString();

            // get html
            var htmlJson = await driver.Dom.GetOuterHtmlAsync(int.Parse(nodeId));
            var html = htmlJson["result"]["outerHTML"].ToString();
        }
    }
}
